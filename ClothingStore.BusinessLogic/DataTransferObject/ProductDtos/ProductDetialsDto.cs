using ClothingStore.DataAccess.Models.ProductModel;
using ClothingStore.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.BusinessLogic.DataTransferObject.ProductDtos
{
    public class ProductDetialsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "Discount Price")]
        public decimal? DiscountPrice { get; set; }
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; } = null!;
        public string Size { get; set; } = null!;
        public string Colors { get; set; } = null!;
        public float Rating { get; set; } = 0;
        [Display(Name = "Stock Quantity")]
        public int StockQuantity { get; set; }
        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; } = null!;
        [Display(Name = "Product Types")]
        public string ProductTypes { get; set; }  = null!;
        [Display(Name = "Discount Status")]
        public string DiscountStatu { get; set; }  = null!;
        [Display(Name = "Product Status")]
        public string ProductStatu { get; set; } = null!;
        public string Genders { get; set; } = null!;

        public int CreatedBy { get; set; }
        public DateOnly DataOfCreation { get; set; }
       
        public int LastModifiedBy { get; set; }
        public DateOnly LastModifiedOn { get; set; }
    }
}
