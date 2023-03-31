using System.Numerics;

namespace StronglyTyped
{
    public interface IStrongSignedNumber<TSelf, TBase> 
        : IStrongType<TSelf, TBase>,
        IComparable,
        IComparable<TSelf>,
        IEquatable<TSelf>,
        IEqualityOperators<TSelf, TSelf, bool>,
        ISpanFormattable,
        ISpanParsable<TSelf>,
        IUnaryPlusOperators<TSelf, TSelf>,
        IUnaryNegationOperators<TSelf, TSelf>
        where TSelf : struct, IStrongSignedNumber<TSelf, TBase>
    {
        static abstract TSelf One { get; }
        static abstract TSelf NegativeOne { get; }
        static abstract TSelf Zero { get; }

        static abstract explicit operator TSelf(TBase value);
        static abstract explicit operator TBase(TSelf value);
    }
}
