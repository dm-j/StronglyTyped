namespace StronglyTyped
{
    public interface IStrongFloat<TSelf> : IStrongSignedNumber<TSelf, float>
        where TSelf : struct, IStrongFloat<TSelf>
    { }
}
