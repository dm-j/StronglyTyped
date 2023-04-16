using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Collections.Concurrent;
using System.Reflection;

namespace StrictlyTyped.EntityFramework;

public static class DbContextConfigurationExtensions
{
    public static void AddStrictTypeConverters(this DbContextOptionsBuilder options) =>
        options.ReplaceService<IValueConverterSelector, StronglyTypedIdValueConverterSelector>();
}

public class StronglyTypedIdValueConverterSelector : ValueConverterSelector
{
    // The dictionary in the base type is private, so we need our own one here.
    private readonly ConcurrentDictionary<(Type ModelClrType, Type ProviderClrType), ValueConverterInfo> _converters
        = new ConcurrentDictionary<(Type ModelClrType, Type ProviderClrType), ValueConverterInfo>();

    public StronglyTypedIdValueConverterSelector(ValueConverterSelectorDependencies dependencies) : base(dependencies)
    { }

    public override IEnumerable<ValueConverterInfo> Select(Type modelClrType, Type? providerClrType = null)
    {
        var baseConverters = base.Select(modelClrType, providerClrType);
        foreach (var converter in baseConverters)
        {
            yield return converter;
        }

        // Extract the "real" type T from Nullable<T> if required
        var underlyingModelType = UnwrapNullableType(modelClrType);
        var underlyingProviderType = UnwrapNullableType(providerClrType!);

        // 'null' means 'get any value converters for the modelClrType'
        if (underlyingModelType.IsAssignableTo(typeof(IStrictType)))
        {
            // Try and get a nested class with the expected name. 
            var converterType = underlyingModelType.GetNestedType("EFConverter");

            if (converterType != null)
            {
                var baseType = 
                    underlyingModelType
                        .GetInterfaces()
                        .Where(intType => intType.IsGenericType && intType.GetGenericTypeDefinition() == typeof(IStrictType<>))
                        .Select(intType => intType.GetGenericArguments()[0])
                        .Single();
                yield return _converters.GetOrAdd(
                    (underlyingModelType, baseType),
                    k =>
                    {
                        Func<ValueConverterInfo, ValueConverter> factory =
                            info => (ValueConverter)Activator.CreateInstance(converterType, info.MappingHints)!;

                        return new ValueConverterInfo(modelClrType, baseType, factory);
                    }
                );
            }
        }
    }

    private static Type UnwrapNullableType(Type type)
    {
        if (type is null) { return default!; }

        return Nullable.GetUnderlyingType(type) ?? type;
    }
}
