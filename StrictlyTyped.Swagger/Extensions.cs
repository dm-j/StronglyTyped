using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Net.NetworkInformation;
using System.Reflection;

namespace StrictlyTyped.Swagger
{
    public static class Extensions
    {
        public static void UseStrictTypesDefinedIn(this SwaggerGenOptions options, Assembly assembly)
        {
            assembly
                .GetTypes()
                .Select(t => (type: t, interfaces: t.GetInterfaces().Where(i => i.IsGenericType).ToArray()))
                .Select(t => 
                    (t.type, 
                    interfaces: t.interfaces
                        .Select(i => i.GetGenericArguments())
                        .Where(genericArguments => genericArguments.Count() == 2)
                        .Where(genericArguments => genericArguments[0] == t.type)
                        .ToArray()))
                .Where(t => t.interfaces.Length == 1)
                .Select(t => (type: t.type, baseType: t.interfaces.Single()[1]))
                .ToList()
                .ForEach(
                    t => options.MapType(t.type, () => new OpenApiSchema { Type = t.baseType.Name })
                );
        }
    }
}