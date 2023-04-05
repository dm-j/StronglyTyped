namespace StrictlyTyped
{
    public interface IStrictBool<TSelf> : 
        IStrictType<TSelf, bool>,
        IComparable,
        IComparable<TSelf>,
        IEquatable<TSelf>
        where TSelf : struct, IStrictBool<TSelf>
    {
        bool IsTrue { get; }
        bool IsFalse { get; }

        static abstract TSelf True { get; }
        static abstract TSelf False { get; }

        /// <summary>
        /// Explicit cast operator that turns a bool into a TSelf. Does not perform validation or preprocessing
        /// </summary>
        /// <param name="value">The TBase to convert</param>
        static abstract explicit operator TSelf(bool value);

        /// <summary>
        /// Implicit cast operator that turns a TSelf back into a bool
        /// </summary>
        /// <param name="value">The TSelf to convert</param>
        static abstract implicit operator bool(TSelf value);
    }
}
