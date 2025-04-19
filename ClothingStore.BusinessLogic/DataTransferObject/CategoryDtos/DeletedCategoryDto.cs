 

namespace ClothingStore.BusinessLogic.DataTransferObject.CategoryDtos
{
    class DeletedCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateOnly DateOfCreation { get; set; }
        public int CreatedBy { get; set; }
        public DateOnly LastMofifedOn { get; set; }
        public int LastMofifedBy { get; set; }
        public string LogoUrl { get; set; } = null!;
    }
}
