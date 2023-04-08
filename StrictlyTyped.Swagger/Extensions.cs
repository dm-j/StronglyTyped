using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace StrictlyTyped.Swagger
{
    public static class Extensions
    {
        public static void UseStrictTypesDefinedIn(this SwaggerGenOptions options, Assembly assembly)
        {
            foreach (var type in assembly
                                    .GetTypes()
                                    .Select(
                                        type => (type,
                                                @interface: type
                                            .GetInterfaces()
                                            .Where(i => i.IsGenericType).Select(i => i.Name).Where(i => i.StartsWith("IStrict")).Select(i => i[7..]).ToList()))
                                    .Where(type => type.@interface.Any()))
            {
                var map = _map(options, type.type);

                if (type.@interface.Any(i => i.StartsWith("String")))
                {
                    map(new OpenApiSchema { Type = "string" });
                    continue;
                }

                if (type.@interface.Any(i => i.StartsWith("Guid")))
                {
                    map(new OpenApiSchema { Type = "string", Format = "uuid" });
                    continue;
                }

                if (type.@interface.Any(i => i.StartsWith("Int")))
                {
                    map(new OpenApiSchema { Type = "integer", Format = "int32" });
                    continue;
                }

                if (type.@interface.Any(i => i.StartsWith("Bool")))
                {
                    map(new OpenApiSchema { Type = "boolean" });
                    continue;
                }

                if (type.@interface.Any(i => i.StartsWith("Long")))
                {
                    map(new OpenApiSchema { Type = "integer", Format = "int64" });
                    continue;
                }

                if (type.@interface.Any(i => i.StartsWith("Float")))
                {
                    map(new OpenApiSchema { Type = "number", Format = "float" });
                    continue;
                }

                if (type.@interface.Any(i => i.StartsWith("Decimal")))
                {
                    map(new OpenApiSchema { Type = "number" });
                    continue;
                }

                if (type.@interface.Any(i => i.StartsWith("Double")))
                {
                    map(new OpenApiSchema { Type = "number", Format = "float" });
                    continue;
                }

                if (type.@interface.Any(i => i.StartsWith("Byte")))
                {
                    map(new OpenApiSchema { Type = "integer", Maximum = Byte.MaxValue, Minimum = Byte.MinValue });
                    continue;
                }

                if (type.@interface.Any(i => i.StartsWith("Short")))
                {
                    map(new OpenApiSchema { Type = "integer", Maximum = Int16.MaxValue, Minimum = Int16.MinValue });
                    continue;
                }

                if (type.@interface.Any(i => i.StartsWith("UShort")))
                {
                    map(new OpenApiSchema { Type = "integer", Maximum = UInt16.MaxValue, Minimum = UInt16.MinValue });
                    continue;
                }

                if (type.@interface.Any(i => i.StartsWith("UInt")))
                {
                    map(new OpenApiSchema { Type = "integer", Maximum = UInt32.MaxValue, Minimum = UInt32.MinValue });
                    continue;
                }

                if (type.@interface.Any(i => i.StartsWith("ULong")))
                {
                    map(new OpenApiSchema { Type = "integer" });
                    continue;
                }

                if (type.@interface.Any(i => i.StartsWith("SByte")))
                {
                    map(new OpenApiSchema { Type = "integer", Maximum = SByte.MaxValue, Minimum = SByte.MinValue });
                    continue;
                }

                if (type.@interface.Any(i => i.StartsWith("UShort")))
                {
                    map(new OpenApiSchema { Type = "integer", Maximum = UInt16.MaxValue, Minimum = UInt16.MinValue });
                    continue;
                }

                if (type.@interface.Any(i => i.StartsWith("Half")))
                {
                    map(new OpenApiSchema { Type = "number", Maximum = (decimal?)Half.MaxValue, Minimum = (decimal?)Half.MinValue });
                    continue;
                }
            }
        }

        private static Action<OpenApiSchema> _map(SwaggerGenOptions options, Type type) =>
            schema => options.MapType(type, () => schema);
    }
}