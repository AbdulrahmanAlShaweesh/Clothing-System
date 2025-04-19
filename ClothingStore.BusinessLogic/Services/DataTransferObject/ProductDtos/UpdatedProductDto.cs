using System.ComponentModel.DataAnnotations;
using ClothingStore.DataAccess.Models.ProductModel;
using ClothingStore.Domain.Enums;

namespace ClothingStore.DataAccess.Services.DataTransferObject.ProductDtos
{
    public class UpdatedProductDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Max Length Should be 50 Characters")]
        [MinLength(5, ErrorMessage = "Min Length Should be 50 Characters")]
        public string Name { get; set; } = null!;
        [MaxLength(50, ErrorMessage = "Max Length Should be 150 Characters")]
        [MinLength(5, ErrorMessage = "Min Length Should be 5 Characters")]
        public string? Description { get; set; }
        public decimal Price { get; set; }
        [Display(Name = "Discount Price")]
        public decimal? DiscountPrice { get; set; }
        [MaxLength(100, ErrorMessage = "Max Length Should be 20 Characters")]
        [Display(Name = "Brand Name")]
        [Required]
        public string BrandName { get; set; } = null!;
        public ProductSize Size { get; set; }
        public ProductColors Colors { get; set; }
        //public float Rating { get; set; } = 0;
        [Display(Name = "Stock Quantity")]
        public int StockQuantity { get; set; }
        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }
        [Display(Name = "Image Url")]
        [Required]
        public string ImageUrl { get; set; } = null!;
        [Display(Name = "Product Types")]
        public ProductType ProductTypes { get; set; }
        [Display(Name = "Discount Status")]
        public DiscountStatus DiscountStatu { get; set; }
        [Display(Name = "Product Status")]
        public ProductStatus ProductStatu { get; set; }
        public Gender Genders { get; set; }
        public DateOnly DateOfCreation { get; set; }
    }
}
