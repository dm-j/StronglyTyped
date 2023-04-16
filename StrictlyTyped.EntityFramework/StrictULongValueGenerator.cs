using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace StrictlyTyped.EntityFramework
{
    public class StrictULongValueGenerator<TStrict> : ValueGenerator where TStrict : struct, IStrictULong<TStrict>
    {
        public override bool GeneratesTemporaryValues => true;
        private ulong _value = (ulong.MaxValue - 1_000);

        protected override object? NextValue(EntityEntry entry) =>
            TStrict.Create(_value++);
    }
}