 
using ClothingStore.DataAccess.Models.ProductModel;
using ClothingStore.DataAccess.Shared.Classess;

namespace ClothingStore.DataAccess.Models.BrandModel
{
    public class ProductBrand : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string BrandLogoUrl { get; set; } = null!;
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
