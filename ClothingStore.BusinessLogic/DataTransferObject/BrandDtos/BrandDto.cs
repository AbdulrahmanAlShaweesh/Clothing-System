
using System.ComponentModel.DataAnnotations;

namespace ClothingStore.BusinessLogic.DataTransferObject.BrandDtos
{
    public class BrandDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [Display(Name = "Date Of Creation")]
        public DateOnly DateOfCreation { get; set; }
        [Display(Name = "Brand Logo Url")]
        public string BrandLogoUrl { get; set; } = null!;
    }
}
