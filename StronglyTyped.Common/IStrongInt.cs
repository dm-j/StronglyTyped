namespace StronglyTyped
{
    public interface IStrongInt<TSelf> : IStrongSignedNumber<TSelf, int>
        where TSelf : struct, IStrongInt<TSelf>
    { }
}
