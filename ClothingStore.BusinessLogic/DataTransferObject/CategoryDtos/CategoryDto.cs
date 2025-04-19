
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.BusinessLogic.DataTransferObject.CategoryDtos
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; } = null!;
        [Display(Name = "Date Of Creation")]
        public DateOnly DateOfCreation { get; set; }
    }
}
