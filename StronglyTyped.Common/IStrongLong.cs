namespace StronglyTyped
{
    public interface IStrongLong<TSelf> : IStrongSignedNumber<TSelf, long>
        where TSelf : struct, IStrongLong<TSelf>
    { }
}
