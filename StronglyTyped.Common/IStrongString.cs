namespace StronglyTyped
{
    public interface IStrongString<TSelf> : 
        IStrongType<TSelf, string>,
        IEquatable<TSelf>,
        IComparable,
        IComparable<TSelf>
        where TSelf : struct, IStrongString<TSelf>
    {
        int Length { get; }
        TSelf Map(Func<string, string> projection);

        /// <summary>
        /// Explicit cast operator that turns a TBase into a TSelf. Does not perform validation or preprocessing
        /// </summary>
        /// <param name="value">The TBase to convert</param>
        static abstract explicit operator TSelf(string value);

        /// <summary>
        /// Explicit cast operator that turns a TSelf back into a TBase
        /// </summary>
        /// <param name="value">The TSelf to convert</param>
        static abstract explicit operator string(TSelf value);
    }
}
