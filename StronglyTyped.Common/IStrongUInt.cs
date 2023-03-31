namespace StronglyTyped
{
    public interface IStrongUInt<TSelf> : IStrongUnsignedNumber<TSelf, uint>
        where TSelf : struct, IStrongUInt<TSelf>
    { }
}
