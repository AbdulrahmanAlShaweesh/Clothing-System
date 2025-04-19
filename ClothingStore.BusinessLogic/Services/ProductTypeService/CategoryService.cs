

using AutoMapper;
using ClothingStore.BusinessLogic.DataTransferObject.CategoryDtos;
using ClothingStore.DataAccess.Models.CategoryModel;
using ClothingStore.DataAccess.Repositories.CategoryRepository;

namespace ClothingStore.BusinessLogic.Services.ProductTypeService
{
    public class CategoryService(ICategoryRepository _categoryRepository, IMapper _mapper) : ICategoryService
    {

        public IEnumerable<CategoryDto> GetAllCategories()
        {
            var Categories = _categoryRepository.GetAll(false);

            var CategoryDto = _mapper.Map <IEnumerable<Category>, IEnumerable<CategoryDto>>(Categories);

            return CategoryDto;
        }

        public int CreatedCategory(CreatedCategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }



        public CategoryDetialsDto? GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdatedCategory(UpdatedCategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
