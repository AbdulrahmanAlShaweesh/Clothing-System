

namespace ClothingStore.DataAccess.Data.Configurations
{
    public class BaseEntityConfigurations<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(P => P.CreatedOn).HasDefaultValueSql("GETDATE()");
            builder.Property(P => P.LastModifiedOn).HasComputedColumnSql("GETDATE()");
        }
    }
}
