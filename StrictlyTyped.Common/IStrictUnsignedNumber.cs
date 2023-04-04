using System.Numerics;

namespace StrictlyTyped
{

    public interface IStrictUnsignedNumber<TSelf, TBase>
        : IStrictType<TSelf, TBase>,
        IComparable,
        IComparable<TSelf>,
        IEquatable<TSelf>,
        IEqualityOperators<TSelf, TSelf, bool>,
        ISpanFormattable,
        ISpanParsable<TSelf>
        where TSelf : struct, IStrictUnsignedNumber<TSelf, TBase>
    {
        static abstract TSelf One { get; }
        static abstract TSelf Zero { get; }

        static abstract explicit operator TSelf(TBase value);
        static abstract explicit operator TBase(TSelf value);
    }
}
