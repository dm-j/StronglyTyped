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
    }
}
