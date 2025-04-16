

namespace ClothingStore.DataAccess.Data.Configurations
{
    class ProductBrandConfgurations : BaseEntityConfigurations<ProductBrand> , IEntityTypeConfiguration<ProductBrand>
    {
        public new void Configure(EntityTypeBuilder<ProductBrand> builder)
        {
            builder.HasKey(B => B.Id);
            builder.Property(B => B.Id).UseIdentityColumn(1, 1);
            builder.Property(B => B.Name).HasColumnType("varchar(50)").IsRequired();
            base.Configure(builder);
        }
    }
}
