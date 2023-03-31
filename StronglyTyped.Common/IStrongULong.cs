namespace StronglyTyped
{
    public interface IStrongULong<TSelf> : IStrongUnsignedNumber<TSelf, ulong>
    where TSelf : struct, IStrongULong<TSelf>
    { }
}
