
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.BusinessLogic.DataTransferObject.ProductDtos
{
    public class DeletedProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public decimal? DiscountPrice { get; set; }
        public string BrandName { get; set; } = null!;
        public string Size { get; set; } = null!;
        public string Colors { get; set; } = null!;
        public float Rating { get; set; } = 0;
        public int StockQuantity { get; set; }
        public bool IsAvailable { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string ProductTypes { get; set; } = null!;
        public string DiscountStatu { get; set; } = null!;
        public string ProductStatu { get; set; } = null!;
        public string Genders { get; set; } = null!;
    }
}
