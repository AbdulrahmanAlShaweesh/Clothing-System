

using ClothingStore.BusinessLogic.DataTransferObject.BrandDtos;

namespace ClothingStore.BusinessLogic.Services.Brand
{
    public interface IBrandServices
    {
        IEnumerable<BrandDto> GetAllPrands();
        BrandDetialsDto? GetBrandById(int id);
        int CreatedBrand(CreatedBrandDto createdBrand); 
        int UpdatedBrand(UpdatedBrandDto updatedBrand);
        bool DeletedBrand(int id);
    }
}
