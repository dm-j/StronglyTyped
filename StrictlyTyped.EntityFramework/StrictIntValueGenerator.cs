using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace StrictlyTyped.EntityFramework
{
    public class StrictIntValueGenerator<TStrict> : ValueGenerator where TStrict : struct, IStrictInt<TStrict>
    {
        public override bool GeneratesTemporaryValues { get; }
        private int _value = int.MinValue;

        protected override object? NextValue(EntityEntry entry) =>
            TStrict.Create(_value++);
    }
}