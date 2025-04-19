

using ClothingStore.BusinessLogic.DataTransferObject.CategoryDtos;

namespace ClothingStore.BusinessLogic.Services.ProductTypeService
{
   public interface ICategoryService
    {

        IEnumerable<CategoryDto> GetAllCategories();
        CategoryDetialsDto? GetCategoryById(int id);
        int CreatedCategory(CreatedCategoryDto categoryDto);
        int UpdatedCategory(UpdatedCategoryDto categoryDto);
        bool DeleteCategory(int id);
    }
}


