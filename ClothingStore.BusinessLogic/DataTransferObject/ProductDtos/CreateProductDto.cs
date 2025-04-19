
using System.ComponentModel.DataAnnotations;
using ClothingStore.DataAccess.Models.ProductModel;
using ClothingStore.Domain.Enums;

namespace ClothingStore.BusinessLogic.DataTransferObject.ProductDtos
{
    public class CreateProductDto
    {
        [Required(ErrorMessage = "Product name is required.")]
        [MaxLength(50, ErrorMessage = "Name can't be longer than 50 characters.")]
        [MinLength(5, ErrorMessage = "Name must be at least 5 characters.")]
        public string Name { get; set; } = null!;
        [MaxLength(150, ErrorMessage = "Description can't exceed 150 characters.")]
        [MinLength(5, ErrorMessage = "Description must be at least 5 characters.")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, 100000, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }
        [Range(0.01, 100000, ErrorMessage = "Discount must be a valid amount.")]
        [Display(Name = "Discount Price")]
        public decimal? DiscountPrice { get; set; }
        [Required(ErrorMessage = "Brand name is required.")]
        [MaxLength(100, ErrorMessage = "Brand name can't exceed 100 characters.")]
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; } = null!;
        [Required(ErrorMessage = "Product size is required.")]
        [EnumDataType(typeof(ProductSize))]
        public ProductSize Size { get; set; }
        [Required(ErrorMessage = "Product color is required.")]
        [EnumDataType(typeof(ProductColors))]
        public ProductColors Colors { get; set; }
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
