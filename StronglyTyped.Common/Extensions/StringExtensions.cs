using System.Diagnostics.CodeAnalysis;

namespace StronglyTyped.Common
{
    public static partial class Extensions
    {
        /// <summary>
        /// Creates a nullable strongly typed value from a nullable string
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <param name="value">The value to attempt to convert</param>
        /// <returns>The (nullable) converted value</returns>
        public static TStrong As<TStrong>([NotNullIfNotNull(nameof(value))] this string value)
            where TStrong : struct, IStrongString<TStrong> =>
            TStrong.From(value);

        /// <summary>
        /// Creates a nullable strongly typed value from a nullable string
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <param name="value">The value to attempt to convert</param>
        /// <returns>The (nullable) converted value</returns>
        public static TStrong? AsNullable<TStrong>([NotNullIfNotNull(nameof(value))] this string? value)
            where TStrong : struct, IStrongString<TStrong> =>
            value is null ? null : TStrong.From(value);

        /// <summary>
        /// Creates a strongly typed value from a string
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <param name="value">The value to attempt to convert</param>
        /// <param name="result">out result</param>
        /// <param name="failures">out reasons why conversion failed</param>
        /// <returns>Whether or not the conversion succeeded</returns>
        public static bool TryAs<TStrong>(this string value, [MaybeNull, NotNullWhen(true)] out TStrong result, out IReadOnlySet<string> failures)
            where TStrong : struct, IStrongString<TStrong> =>
            TStrong.TryFrom(value, out result, out failures);

        /// <summary>
        /// Creates a strongly typed value from a string
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <param name="value">The value to attempt to convert</param>
        /// <param name="result">out result</param>
        /// <returns>Whether or not the conversion succeeded</returns>
        public static bool TryAs<TStrong>(this string value, [MaybeNull, NotNullWhen(true)] out TStrong result)
            where TStrong : struct, IStrongString<TStrong> =>
            TStrong.TryFrom(value, out result, out _);

        /// <summary>
        /// Creates a nullable strongly typed value from a nullable Guid
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <param name="value">The value to convert</param>
        /// <param name="result">out result</param>
        /// <returns>Whether or not the conversion succeeded</returns>
        public static bool TryAsNullable<TStrong>(this string? value, out TStrong? result, out IReadOnlySet<string> failures)
            where TStrong : struct, IStrongString<TStrong>
        {
            if (value is null)
            {
                result = default;
                failures = EmptyStringSet.Instance;
                return true;
            }

            var success = TStrong.TryFrom(value, out var r, out failures);

            result = success ? r : default;

            return success;
        }

        /// <summary>
        /// Creates a nullable strongly typed value from a nullable Guid
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <param name="value">The value to convert</param>
        /// <param name="result">out result</param>
        /// <returns>Whether or not the conversion succeeded</returns>
        public static bool TryAsNullable<TStrong>(this string? value, out TStrong? result)
            where TStrong : struct, IStrongString<TStrong> =>
            value.TryAsNullable(out result, out _);
    }
}
