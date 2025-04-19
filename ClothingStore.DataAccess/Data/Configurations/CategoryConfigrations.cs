

using ClothingStore.DataAccess.Models.CategoryModel;

namespace ClothingStore.DataAccess.Data.Configurations
{
    class CategoryConfigrations : BaseEntityConfigurations<Category>, IEntityTypeConfiguration<Category>
    {
        public new void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(C => C.Id);
            builder.Property(C => C.Id).UseIdentityColumn(1, 1);
            builder.Property(C => C.Name).HasColumnType("varchar(30)").IsRequired();
            builder.Property(C => C.Description).HasColumnType("varchar(150)");
            base.Configure(builder);
        }
    }
}

