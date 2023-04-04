using System.Diagnostics.CodeAnalysis;

namespace StrictlyTyped
{
    public static partial class Extensions
    {
        /// <summary>
        /// Creates a strictly typed value from its base
        /// </summary>
        /// <typeparam name="TStrict">Destination type</typeparam>
        /// <typeparam name="TBase">Base type</typeparam>
        /// <param name="value">The value to convert</param>
        /// <returns>The converted value</returns>
        public static TStrict As<TStrict, TBase>(this TBase value)
            where TStrict : struct, IStrictType<TStrict, TBase> =>
            TStrict.From(value);

        /// <summary>
        /// Creates a strictly typed value from its base. This operation can fail.
        /// </summary>
        /// <typeparam name="TStrict">Destination type</typeparam>
        /// <typeparam name="TBase">Base type</typeparam>
        /// <param name="value">The value to attempt to convert</param>
        /// <param name="result">out TStrict result</param>
        /// <param name="failures">out reasons why the conversion failed</param>
        /// <returns>Whether or not the conversion succeeded</returns>
        public static bool TryAs<TStrict, TBase>(this TBase value, [MaybeNull, NotNullWhen(true)] out TStrict result, out IReadOnlySet<string> failures)
            where TStrict : struct, IStrictType<TStrict, TBase> =>
            TStrict.TryFrom(value, out result, out failures);

        /// <summary>
        /// Creates a strictly typed value from its base. This operation can fail.
        /// </summary>
        /// <typeparam name="TStrict">Destination type</typeparam>
        /// <typeparam name="TBase">Base type</typeparam>
        /// <param name="value">The value to attempt to convert</param>
        /// <param name="result">out TStrict result</param>
        /// <returns>Whether or not the conversion succeeded</returns>
        public static bool TryAs<TStrict, TBase>(this TBase value, [MaybeNull, NotNullWhen(true)] out TStrict result)
            where TStrict : struct, IStrictType<TStrict, TBase> =>
            TStrict.TryFrom(value, out result, out _);

        /// <summary>
        /// Maps a strict type as though it were the wrapped type
        /// </summary>
        /// <typeparam name="TResult">The result of the Func</typeparam>
        /// <typeparam name="TBase">The base of the strict type</typeparam>
        /// <param name="value">The value to map</param>
        /// <param name="map">The Func to apply to the wrapped value</param>
        /// <returns>The result of the map Func</returns>
        public static TResult Map<TResult, TBase>(this IStrictType<TBase> value, Func<TBase, TResult> map) =>
            map(value.Value);

        /// <summary>
        /// Maps a strict type as though it were the wrapped type and converts the result to another strict type
        /// </summary>
        /// <typeparam name="TBase">The base of the strict type</typeparam>
        /// <typeparam name="TBaseResult">The result of the map Func</typeparam>
        /// <typeparam name="TResult">The strict type to convert the result to</typeparam>
        /// <param name="value">The value to map</param>
        /// <param name="map">The Func to apply to the wrapped value</param>
        /// <returns>The strict type that wraps the result</returns>
        public static TResult Map<TBase, TBaseResult, TResult>(this IStrictType<TBase> value, Func<TBase, TBaseResult> map)
            where TResult : struct, IStrictType<TResult, TBaseResult> =>
            TResult.From(map(value.Value));
    }
}
