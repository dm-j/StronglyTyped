namespace StronglyTyped
{
    public interface IStrongDecimal<TSelf> : IStrongSignedNumber<TSelf, decimal>
    where TSelf : struct, IStrongDecimal<TSelf>
    { }
}
