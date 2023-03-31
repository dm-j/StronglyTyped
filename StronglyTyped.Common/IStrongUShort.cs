namespace StronglyTyped
{
    public interface IStrongUShort<TSelf> : IStrongUnsignedNumber<TSelf, ushort>
    where TSelf : struct, IStrongUShort<TSelf>
    { }
}
