using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace StrictlyTyped.EntityFramework
{
    public class StrictUIntValueGenerator<TStrict> : ValueGenerator where TStrict : struct, IStrictUInt<TStrict>
    {
        public override bool GeneratesTemporaryValues => true;
        private uint _value = (uint.MaxValue - 1_000);

        protected override object? NextValue(EntityEntry entry) =>
            TStrict.Create(_value++);
    }
}