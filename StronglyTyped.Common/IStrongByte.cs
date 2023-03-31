namespace StronglyTyped
{
    public interface IStrongByte<TSelf> : IStrongUnsignedNumber<TSelf, byte>
        where TSelf : struct, IStrongByte<TSelf>
    { }
}
