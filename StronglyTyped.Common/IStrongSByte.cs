namespace StronglyTyped
{
    public interface IStrongSByte<TSelf> : IStrongSignedNumber<TSelf, sbyte>
        where TSelf : struct, IStrongSByte<TSelf>
    { }
}
