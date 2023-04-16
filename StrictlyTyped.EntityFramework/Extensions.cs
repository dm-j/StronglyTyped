using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq.Expressions;

namespace StrictlyTyped.EntityFramework
{
    public static class Extensions
    {
        public static PropertyBuilder<TStrict> StrictInt<TStrict, TModel>(this EntityTypeBuilder<TModel> builder, Expression<Func<TModel, TStrict>> propertyExpression)
            where TStrict : struct, IStrictInt<TStrict> where TModel : class
        {
            return builder
                .Property(propertyExpression)
                .HasStrictTypeConverter<TStrict, int>();
        }

        public static PropertyBuilder<TStrict?> StrictInt<TStrict, TModel>(this EntityTypeBuilder<TModel> builder, Expression<Func<TModel, TStrict?>> propertyExpression)
            where TStrict : struct, IStrictInt<TStrict> where TModel : class
        {
            return builder
                .Property(propertyExpression)
                .HasStrictTypeConverter<TStrict, int>();
        }

        public static PropertyBuilder<TStrict> StrictString<TStrict, TModel>(this EntityTypeBuilder<TModel> builder, Expression<Func<TModel, TStrict>> propertyExpression)
            where TStrict : struct, IStrictString<TStrict> where TModel : class
        {
            return builder
                .Property(propertyExpression)
                .HasStrictTypeConverter<TStrict, string>();
        }

        public static PropertyBuilder<TStrict?> StrictString<TStrict, TModel>(this EntityTypeBuilder<TModel> builder, Expression<Func<TModel, TStrict?>> propertyExpression)
            where TStrict : struct, IStrictString<TStrict> where TModel : class
        {
            return builder
                .Property(propertyExpression)
                .HasStrictTypeConverter<TStrict, string>();
        }

        public static PropertyBuilder<TStrict> StrictBool<TStrict, TModel>(this EntityTypeBuilder<TModel> builder, Expression<Func<TModel, TStrict>> propertyExpression)
            where TStrict : struct, IStrictBool<TStrict> where TModel : class
        {
            return builder
                .Property(propertyExpression)
                .HasStrictTypeConverter<TStrict, bool>();
        }

        public static PropertyBuilder<TStrict?> StrictBool<TStrict, TModel>(this EntityTypeBuilder<TModel> builder, Expression<Func<TModel, TStrict?>> propertyExpression)
            where TStrict : struct, IStrictBool<TStrict> where TModel : class
        {
            return builder
                .Property(propertyExpression)
                .HasStrictTypeConverter<TStrict, bool>();
        }

        public static PropertyBuilder<TStrict> HasStrictTypeConverter<TStrict, TBase>(this PropertyBuilder<TStrict> builder) where TStrict : struct, IStrictType<TStrict, TBase>
        {
            builder.HasConversion<StrictTypeConverter<TStrict, TBase>>();
            return builder;
        }

        public static PropertyBuilder<TStrict?> HasStrictTypeConverter<TStrict, TBase>(this PropertyBuilder<TStrict?> builder) where TStrict : struct, IStrictType<TStrict, TBase>
        {
            builder.HasConversion<StrictTypeConverter<TStrict, TBase>>();
            return builder;
        }
    }
}
