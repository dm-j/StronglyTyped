using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Collections.Concurrent;

namespace StrictlyTyped.EntityFramework;

public static class DependencyInjectionExtensions
{
    public static DbContextOptionsBuilder AddStrictTypeConverters(this DbContextOptionsBuilder builder)
    {
        return builder.ReplaceService<IValueConverterSelector, StrictlyTypedValueConverterSelector>();
    }
}

public class StrictlyTypedValueConverterSelector : ValueConverterSelector
{
    private static readonly Type[] _convertedTypes = new[] {
        typeof(bool),
        typeof(byte),
        typeof(decimal),
        typeof(double),
        typeof(float),
        typeof(Guid),
        typeof(Half),
        typeof(int),
        typeof(long),
        typeof(sbyte),
        typeof(short),
        typeof(string),
        typeof(uint),
        typeof(ulong),
        typeof(ushort),
    }; 

    // The dictionary in the base type is private, so we need our own one here.
    private readonly ConcurrentDictionary<(Type ModelClrType, Type ProviderClrType), ValueConverterInfo> _converters
        = new();

    public StrictlyTypedValueConverterSelector(ValueConverterSelectorDependencies dependencies) : base(dependencies)
    { }

    public override IEnumerable<ValueConverterInfo> Select(Type modelClrType, Type? providerClrType = null)
    {
        var baseConverters = base.Select(modelClrType, providerClrType);
        foreach (var converter in baseConverters)
        {
            yield return converter;
        }

        // Extract the "real" type T from Nullable<T> if required
        var underlyingModelType = _unwrapNullableType(modelClrType);
        var underlyingProviderType = _unwrapNullableType(providerClrType!);

        // 'null' means 'get any value converters for the modelClrType'
        if (underlyingProviderType is null || _convertedTypes.Contains(underlyingProviderType))
        {
            // Try and get a nested class with the expected name. 
            var converterType = underlyingModelType.GetNestedType("EFConverter");

            if (converterType != null)
            {
                yield return _converters.GetOrAdd(
                    (underlyingModelType, underlyingProviderType!),
                    k =>
                    {
                        // Create an instance of the converter whenever it's requested.
                        Func<ValueConverterInfo, ValueConverter> factory =
                            info => (ValueConverter)Activator.CreateInstance(converterType, info.MappingHints)!;

                        // Build the info for our strongly-typed ID => int converter
                        return new ValueConverterInfo(modelClrType, typeof(int), factory);
                    }
                );
            }
        }
    }

    private static Type _unwrapNullableType(Type type)
    {
        if (type is null) { return default!; }

        return Nullable.GetUnderlyingType(type) ?? type;
    }
}