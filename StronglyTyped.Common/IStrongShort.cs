namespace StronglyTyped
{
    public interface IStrongShort<TSelf> : IStrongSignedNumber<TSelf, short>
        where TSelf : struct, IStrongShort<TSelf>
    { }
}
