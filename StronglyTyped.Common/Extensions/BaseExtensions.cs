using System.Diagnostics.CodeAnalysis;

namespace StronglyTyped.Common
{
    public static partial class Extensions
    {
        /// <summary>
        /// Creates a strongly typed value from its base
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <typeparam name="TBase">Base type</typeparam>
        /// <param name="value">The value to convert</param>
        /// <returns>The converted value</returns>
        public static TStrong As<TStrong, TBase>(this TBase value)
            where TStrong : struct, IStrongType<TStrong, TBase> =>
            TStrong.From(value);

        /// <summary>
        /// Creates a strongly typed value from its base. This operation can fail.
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <typeparam name="TBase">Base type</typeparam>
        /// <param name="value">The value to attempt to convert</param>
        /// <param name="result">out TStrong result</param>
        /// <param name="failures">out reasons why the conversion failed</param>
        /// <returns>Whether or not the conversion succeeded</returns>
        public static bool TryAs<TStrong, TBase>(this TBase value, [MaybeNull, NotNullWhen(true)] out TStrong result, out IReadOnlySet<string> failures)
            where TStrong : struct, IStrongType<TStrong, TBase> =>
            TStrong.TryFrom(value, out result, out failures);

        /// <summary>
        /// Creates a strongly typed value from its base. This operation can fail.
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <typeparam name="TBase">Base type</typeparam>
        /// <param name="value">The value to attempt to convert</param>
        /// <param name="result">out TStrong result</param>
        /// <returns>Whether or not the conversion succeeded</returns>
        public static bool TryAs<TStrong, TBase>(this TBase value, [MaybeNull, NotNullWhen(true)] out TStrong result)
            where TStrong : struct, IStrongType<TStrong, TBase> =>
            TStrong.TryFrom(value, out result, out _);

        /// <summary>
        /// Maps a strong type as though it were the wrapped type
        /// </summary>
        /// <typeparam name="TResult">The result of the Func</typeparam>
        /// <typeparam name="TBase">The base of the strong type</typeparam>
        /// <param name="value">The value to map</param>
        /// <param name="map">The Func to apply to the wrapped value</param>
        /// <returns>The result of the map Func</returns>
        public static TResult Map<TResult, TBase>(this IStrongType<TBase> value, Func<TBase, TResult> map) =>
            map(value.Value);

        /// <summary>
        /// Maps a strong type as though it were the wrapped type and converts the result to another strong type
        /// </summary>
        /// <typeparam name="TBase">The base of the strong type</typeparam>
        /// <typeparam name="TBaseResult">The result of the map Func</typeparam>
        /// <typeparam name="TResult">The strong type to convert the result to</typeparam>
        /// <param name="value">The value to map</param>
        /// <param name="map">The Func to apply to the wrapped value</param>
        /// <returns>The strong type that wraps the result</returns>
        public static TResult Map<TBase, TBaseResult, TResult>(this IStrongType<TBase> value, Func<TBase, TBaseResult> map)
            where TResult : struct, IStrongType<TResult, TBaseResult> =>
            TResult.From(map(value.Value));
    }
}
