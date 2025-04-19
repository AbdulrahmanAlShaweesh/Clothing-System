
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.BusinessLogic.DataTransferObject.CategoryDtos
{
    public class CreatedCategoryDto
    {
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(50, ErrorMessage = "Name can't be longer than 50 characters.")]
        [MinLength(5, ErrorMessage = "Name must be at least 5 characters.")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Date Of Creation name is required.")]
        [Display(Name = "Date Of Creation")]
        public string? Description { get; set; }
        [Display(Name = "Image Url")]
        [Required(ErrorMessage = "Image Url is required.")]
        public string ImageUrl { get; set; } = null!;
    }
}
