using System.Numerics;

namespace StrictlyTyped
{
    public interface IStrictString<TSelf> : 
        IStrictType<TSelf, string>,
        IEquatable<TSelf>,
        IComparable,
        IComparable<TSelf>,
        IEqualityOperators<TSelf, TSelf, bool>
        where TSelf : struct, IStrictString<TSelf>
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

        static abstract bool operator ==(TSelf left, string right);
        static abstract bool operator !=(TSelf left, string right);
        static abstract bool operator ==(string left, TSelf right);
        static abstract bool operator !=(string left, TSelf right);


    }
}
