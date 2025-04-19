

namespace ClothingStore.BusinessLogic.DataTransferObject.CategoryDtos
{
    public class CategoryDetialsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string ImageUrl { get; set; } = null!;
        public int CreatedOn { get; set; }
        public int LastModifiedBy { get; set; }
        public DateOnly LastModifiedOn { get; set; }
    }
}
