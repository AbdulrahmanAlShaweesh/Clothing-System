
using ClothingStore.BusinessLogic.Factories;
using ClothingStore.BusinessLogic.Services.DataTransferObject.BrandDtos;
using ClothingStore.DataAccess.Repositories.BrandRepsoitory;

namespace ClothingStore.BusinessLogic.Services.Brand
{
    public class BrandServices(IBrandRepsotitory _brandRepository) : IBrandServices
    {


        public IEnumerable<BrandDto> GetAllPrands()
        {
            var Brands = _brandRepository.GetAll(false);

            return Brands.Select(B => B.ToBrand());  // map into BrandDto
        }

        public BrandDetialsDto? GetBrandById(int id)
        {
             var Brand = _brandRepository.GetById(id);

            return Brand is null ? null : Brand.ToBrandDetials();
        }


        public int CreatedBrand(CreatedBrandDto createdBrand)
        {
            var Brand = createdBrand.ToEntity();
            return _brandRepository.Add(Brand);
        }

        public int UpdatedBrand(UpdatedBrandDto updatedBrand)
        {
            var Brand = updatedBrand.ToEntity();
            return _brandRepository.Update(Brand);
        }

        public bool DeletedBrand(int id)
        {
            var Brand = _brandRepository.GetById(id);

            if (Brand is null) return false;
            else
            {
                Brand.IsDeleted = true;
                return _brandRepository.Update(Brand) > 0 ? true : false;
            }
        }
    }
}
