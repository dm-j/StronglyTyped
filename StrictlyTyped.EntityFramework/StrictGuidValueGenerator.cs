using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace StrictlyTyped.EntityFramework
{
    public class StrictGuidValueGenerator<TStrict> : ValueGenerator where TStrict : struct, IStrictGuid<TStrict>
    {
        public override bool GeneratesTemporaryValues => true;

        protected override object? NextValue(EntityEntry entry) =>
            TStrict.New();
    }
}