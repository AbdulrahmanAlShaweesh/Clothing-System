
namespace ClothingStore.DataAccess.Data.Configurations
{
    class ProductConfigurations : BaseEntityConfigurations<Product>, IEntityTypeConfiguration<Product> 
    {
        public new void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(P => P.Id);
            builder.HasOne(P => P.ProductBrand)
                    .WithMany(B => B.Products)
                     .HasForeignKey(P => P.BrandId)
                     .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(C => C.Category)
                   .WithMany(P =>  P.Products)
                   .HasForeignKey(P => P.CategoryId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(P => P.Id).UseIdentityColumn(1, 1);
            builder.Property(P => P.Name).HasColumnType("varchar(50)").IsRequired();
            builder.Property(P => P.BrandName).IsRequired().HasMaxLength(50);
            builder.Property(P => P.DiscountPrice).HasColumnType("decimal(18,2)");
            builder.Property(P => P.Rating).HasDefaultValue(0);
            builder.Property(P => P.IsAvailable).IsRequired();
            builder.Property(P => P.ImageUrl).IsRequired();
            builder.Property(P => P.StockQuantity).HasDefaultValue(0);
            base.Configure(builder);
        }
    }
}

