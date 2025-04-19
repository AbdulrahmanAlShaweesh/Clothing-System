using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ClothingStore.DataAccess.Models.BrandModel;
using ClothingStore.DataAccess.Models.CategoryModel;
using ClothingStore.DataAccess.Shared.Classess;
using ClothingStore.Domain.Enums;

namespace ClothingStore.DataAccess.Models.ProductModel
{
   public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal? DiscountPrice { get; set; }
        [MaxLength(100)]
        public string BrandName { get; set; } = null!;
        public ProductSize Size { get; set; }
        public ProductColors Colors { get; set; }
        public float Rating { get; set; } = 0;        // ask khalid....
        public int StockQuantity { get; set; }
        public bool IsAvailable { get; set; }
        public string ImageUrl { get; set; } = null!;
        public ProductType ProductTypes { get; set; }
        public DiscountStatus  DiscountStatu { get; set; }
        public ProductStatus ProductStatu { get; set; }
        public Gender Genders { get; set; }

        // Navigational Properity
        public int BrandId { get; set; }
        public ProductBrand ProductBrand { get; set; } = null!;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
