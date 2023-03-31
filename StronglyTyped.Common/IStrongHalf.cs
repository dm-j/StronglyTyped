namespace StronglyTyped
{
    public interface IStrongHalf<TSelf> : IStrongSignedNumber<TSelf, Half>
        where TSelf : struct, IStrongHalf<TSelf>
    { }
}
