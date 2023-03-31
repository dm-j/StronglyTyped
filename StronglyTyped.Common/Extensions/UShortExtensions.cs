using System.Diagnostics.CodeAnalysis;

namespace StronglyTyped.Common
{
    public static partial class Extensions
    {
        public static TStrong As<TStrong>(this ushort value)
            where TStrong : struct, IStrongUShort<TStrong> =>
            TStrong.From(value);

        public static TStrong? AsNullable<TStrong>(this ushort? value)
            where TStrong : struct, IStrongUShort<TStrong> =>
            value.HasValue ? TStrong.From(value.Value) : null;

        public static bool TryAs<TStrong>(this ushort? value, [NotNullWhen(true)] out TStrong result, out IReadOnlySet<string> failures)
            where TStrong : struct, IStrongUShort<TStrong>
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

        public static bool TryAsNullable<TStrong>(this ushort? value, [NotNullWhen(true)] out TStrong result, out IReadOnlySet<string> failures)
            where TStrong : struct, IStrongUShort<TStrong>
        {
            if (value is null)
            {
                result = default!;
                failures = EmptyStringSet.Instance;
                return true;
            }

            var success = TStrong.TryFrom(value.Value, out var r, out failures);

            result = success ? r : default;

            return success;
        }

        public static bool TryAs<TStrong>(this ushort? value, [NotNullWhen(true)] out TStrong result)
            where TStrong : struct, IStrongUShort<TStrong> =>
            value.TryAs(out result, out _);

        public static bool TryAsNullable<TStrong>(this ushort? value, [NotNullWhen(true)] out TStrong result)
            where TStrong : struct, IStrongUShort<TStrong> =>
            value.TryAsNullable(out result, out _);
    }
}
