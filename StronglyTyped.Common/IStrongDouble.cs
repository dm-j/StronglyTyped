namespace StronglyTyped
{
    public interface IStrongDouble<TSelf> : IStrongSignedNumber<TSelf, double>
    where TSelf : struct, IStrongDouble<TSelf>
    { }
}
