

using System.ComponentModel.DataAnnotations;

namespace ClothingStore.BusinessLogic.DataTransferObject.BrandDtos
{
    class DeletedBrandDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CreatedBy { get; set; }
        [Display(Name = "Date Of Creation")]
        public DateOnly DateOfCreation { get; set; }
        [Display(Name = "Last Modified By")]
        public int LastModifiedBy { get; set; }
        [Display(Name = "Last Modified On")]
        public DateOnly LastModifiedOn { get; set; }
        [Display(Name = "Brand Logo Url")]
        public string BrandLogoUrl { get; set; } = null!;
    }
}
