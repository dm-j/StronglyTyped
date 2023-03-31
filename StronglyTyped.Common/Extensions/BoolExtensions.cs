namespace StronglyTyped.Common
{
    public static partial class Extensions
    {
        /// <summary>
        /// Creates a strongly typed value from a bool
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <param name="value">The value to attempt to convert</param>
        /// <returns>The converted value</returns>
        public static TStrong As<TStrong>(this bool value)
            where TStrong : struct, IStrongBool<TStrong> =>
            TStrong.From(value);

        /// <summary>
        /// Creates a strongly typed value from a nullable bool
        /// </summary>
        /// <typeparam name="TStrong">Destination type</typeparam>
        /// <param name="value">The value to attempt to convert</param>
        /// <returns>The converted value</returns>
        public static TStrong? AsNullable<TStrong>(this bool? value)
            where TStrong : struct, IStrongBool<TStrong> =>
            value.HasValue ? TStrong.From(value.Value) : default!;
    }
}
