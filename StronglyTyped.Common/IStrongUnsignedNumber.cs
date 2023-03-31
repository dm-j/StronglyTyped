using System.Numerics;

namespace StronglyTyped
{

    public interface IStrongUnsignedNumber<TSelf, TBase>
        : IStrongType<TSelf, TBase>,
        IComparable,
        IComparable<TSelf>,
        IEquatable<TSelf>,
        IEqualityOperators<TSelf, TSelf, bool>,
        ISpanFormattable,
        ISpanParsable<TSelf>
        where TSelf : struct, IStrongUnsignedNumber<TSelf, TBase>
    {
        static abstract TSelf One { get; }
        static abstract TSelf Zero { get; }

        static abstract explicit operator TSelf(TBase value);
        static abstract explicit operator TBase(TSelf value);
    }
}
