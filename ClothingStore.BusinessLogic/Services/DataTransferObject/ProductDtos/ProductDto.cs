
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.DataAccess.Services.DataTransferObject.ProductDtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "Discount Price")]
        public decimal? DiscountPrice { get; set; }
        [MaxLength(100)]
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; } = null!;
        public float Rating { get; set; } = 0;
        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; } = null!;
        public DateOnly DateOfCreation { get; set; }
    }
}
