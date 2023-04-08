using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace StrictlyTyped.EntityFramework
{
    public class StrictTypeConverter<TSelf, TBase> : ValueConverter<TSelf, TBase> where TSelf : struct, IStrictType<TSelf, TBase>
    {
        public StrictTypeConverter()
            : base(v => v.Value, v => ConvertTo(v))
        { }

        private static TSelf ConvertTo(TBase value) =>
            (TSelf)value;
    }
}