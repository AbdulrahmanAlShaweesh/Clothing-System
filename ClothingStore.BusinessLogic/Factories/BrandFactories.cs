
using ClothingStore.BusinessLogic.Services.DataTransferObject.BrandDtos;
using ClothingStore.DataAccess.Models.BrandModel;

namespace ClothingStore.BusinessLogic.Factories
{
    static class BrandFactories
    {
        public static BrandDto ToBrand(this ProductBrand brand)
        {
            return new BrandDto()
            {
                Id = brand.Id,
                Name = brand.Name,
                BrandLogoUrl = brand.BrandLogoUrl,
                DateOfCreation = DateOnly.FromDateTime(brand.CreatedOn),
            };
        }

        public static BrandDetialsDto ToBrandDetials(this ProductBrand brandDetials)
        {
            return new BrandDetialsDto()
            {
                Id = brandDetials.Id,
                Name = brandDetials.Name,
                CreatedBy = brandDetials.CreatedBy,
                DateOfCreation = DateOnly.FromDateTime(brandDetials.CreatedOn),
                LastModifiedBy = brandDetials.LastModifiedBy,
                LastModifiedOn = DateOnly.FromDateTime(brandDetials.LastModifiedOn),
                BrandLogoUrl = brandDetials.BrandLogoUrl,
            };
        }

        public static ProductBrand ToEntity(this CreatedBrandDto createdBrand)
        {
            return new ProductBrand()
            {
                Name = createdBrand.Name,
                BrandLogoUrl = createdBrand.LogoUrl,
                CreatedOn = createdBrand.DateOfCreation.ToDateTime(new TimeOnly()),
            };
        }

        public static ProductBrand ToEntity(this UpdatedBrandDto updatedBrand)
        {
            return new ProductBrand()
            {
                Id = updatedBrand.Id,
                Name = updatedBrand.Name,
                BrandLogoUrl= updatedBrand.LogoUrl,
                CreatedOn = updatedBrand.DateOfCreation.ToDateTime(new TimeOnly()),
            };
        }
    }
}
