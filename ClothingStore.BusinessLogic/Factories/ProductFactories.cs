

using ClothingStore.DataAccess.Models.ProductModel;
using ClothingStore.DataAccess.Services.DataTransferObject.ProductDtos;

namespace ClothingStore.BusinessLogic.Factories
{
    static class ProductFactories
    {
        public static ProductDto ToProductDto(this Product product)
        {
            return new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                DiscountPrice = product.DiscountPrice,
                BrandName = product.BrandName,
                Rating = product.Rating,
                IsAvailable = product.IsAvailable,
                ImageUrl = product.ImageUrl,
                DateOfCreation = DateOnly.FromDateTime(product.CreatedOn)
            };
        }

        public static ProductDetialsDto ToProductDetailDto(this Product product)
        {
            return new ProductDetialsDto()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                DiscountPrice = product.DiscountPrice,
                BrandName = product.BrandName,
                Size = product.Size.ToString(),
                Colors = product.Colors.ToString(),
                Rating = product.Rating,
                StockQuantity = product.StockQuantity,
                IsAvailable = product.IsAvailable,
                ImageUrl = product.ImageUrl,
                ProductTypes = product.ProductTypes.ToString(),
                ProductStatu = product.ProductStatu.ToString(),
                DiscountStatu = product.DiscountStatu.ToString(),
                Genders = product.Genders.ToString(),
                CreatedBy = product.CreatedBy,
                DataOfCreation = DateOnly.FromDateTime(product.CreatedOn),
                LastModifiedBy = product.LastModifiedBy,
                LastModifiedOn = DateOnly.FromDateTime(product.LastModifiedOn),
            };
        }

        public static Product ToEntity(this CreateProductDto CreatedProduct)
        {
            return new Product()
            {
                Name = CreatedProduct.Name,
                Description = CreatedProduct.Description,
                Price = CreatedProduct.Price,
                DiscountPrice = CreatedProduct.DiscountPrice,
                BrandName = CreatedProduct.BrandName,
                Size = CreatedProduct.Size,
                Colors = CreatedProduct.Colors,
                //Rating = entity.Rating, 
                StockQuantity = CreatedProduct.StockQuantity,
                IsAvailable = CreatedProduct.IsAvailable,
                ImageUrl = CreatedProduct.ImageUrl,
                ProductTypes = CreatedProduct.ProductTypes,
                ProductStatu = CreatedProduct.ProductStatu,
                DiscountStatu = CreatedProduct.DiscountStatu,
                Genders = CreatedProduct.Genders,
                CreatedOn = CreatedProduct.DateOfCreation.ToDateTime(new TimeOnly())

            };
        }

        public static Product ToEntity(this UpdatedProductDto UpdatedProduct)
        {
            return new Product()
            {
                Id = UpdatedProduct.Id,
                Name = UpdatedProduct.Name,
                Description = UpdatedProduct.Description,
                Price = UpdatedProduct.Price,
                DiscountPrice = UpdatedProduct.DiscountPrice,
                BrandName = UpdatedProduct.BrandName,
                Size = UpdatedProduct.Size,
                Colors = UpdatedProduct.Colors,
                StockQuantity = UpdatedProduct.StockQuantity,
                IsAvailable = UpdatedProduct.IsAvailable,
                ImageUrl = UpdatedProduct.ImageUrl,
                ProductTypes = UpdatedProduct.ProductTypes,
                DiscountStatu = UpdatedProduct.DiscountStatu,
                ProductStatu = UpdatedProduct.ProductStatu,
                Genders = UpdatedProduct.Genders,
                CreatedOn = UpdatedProduct.DateOfCreation.ToDateTime(new TimeOnly()),
            };
        }
    }
}



