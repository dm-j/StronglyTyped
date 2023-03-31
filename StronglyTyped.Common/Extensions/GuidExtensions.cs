using System.Diagnostics.CodeAnalysis;

namespace StronglyTyped.Common
{
    public static partial class StrongTypeExtensions
    {
        /// <summary>
        /// Creates a strongly typed value from a Guid
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <param name="value">The value to attempt to convert</param>
        /// <returns>The converted value</returns>
        public static TStrong As<TStrong>(this Guid value)
            where TStrong : struct, IStrongGuid<TStrong> =>
            TStrong.From(value);

        /// <summary>
        /// Creates a strongly typed value from a Guid
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <param name="value">The value to attempt to convert</param>
        /// <returns>The converted value</returns>
        public static TStrong? AsNullable<TStrong>(this Guid? value)
            where TStrong : struct, IStrongGuid<TStrong> =>
            value.HasValue ? TStrong.From(value.Value) : null;

        /// <summary>
        /// Creates a nullable strongly typed value from a Guid
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <param name="value">The value to attempt to convert</param>
        /// <param name="result">out result</param>
        /// <returns>Whether or not the conversion succeeded</returns>
        public static bool TryAs<TStrong>(this Guid value, [MaybeNull, NotNullWhen(true)] out TStrong result)
            where TStrong : struct, IStrongGuid<TStrong> =>
            TStrong.TryFrom(value, out result, out _);

        /// <summary>
        /// Creates a strongly typed value from a Guid
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <param name="value">The value to convert</param>
        /// <param name="result">out result</param>
        /// <param name="failures">out reasons why conversion failed</param>
        /// <returns>Whether or not the conversion succeeded</returns>
        public static bool TryAs<TStrong>(this Guid? value, [MaybeNull, NotNullWhen(true)] out TStrong result, out IReadOnlySet<string> failures)
            where TStrong : struct, IStrongGuid<TStrong>
        {
            if (value is null)
            {
                result = default!;
                failures = new[] { $"Cannot create {typeof(TStrong).FullName} from <null>" }.ToHashSet();
                return false;
            }

            var success = TStrong.TryFrom(value.Value, out var r, out failures);

            result = success ? r : default;

            return success;
        }

        /// <summary>
        /// Creates a nullable strongly typed value from a nullable Guid
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <param name="value">The value to convert</param>
        /// <param name="result">out result</param>
        /// <param name="failures">out reasons why the conversion failed</param>
        /// <returns>Whether or not the conversion succeeded</returns>
        public static bool TryAsNullable<TStrong>(this Guid? value, out TStrong? result, out IReadOnlySet<string> failures)
            where TStrong : struct, IStrongGuid<TStrong>
        {
            if (value is null)
            {
                result = default;
                failures = EmptyStringSet.Instance;
                return true;
            }

            var success = TStrong.TryFrom(value.Value, out var r, out failures);

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
        public static bool TryAsNullable<TStrong>(this Guid? value, out TStrong? result)
            where TStrong : struct, IStrongGuid<TStrong> =>
            value.TryAsNullable(out result, out _);
    }
}
