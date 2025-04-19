

using ClothingStore.BusinessLogic.DataTransferObject.ProductDtos;
using ClothingStore.BusinessLogic.Factories;
using ClothingStore.DataAccess.Repositories.ProductRepository;

namespace ClothingStore.BusinessLogic.Services.Product
{
    public class ProductService(IProductRepository _productRepository) : IProductService
    {

        public IEnumerable<ProductDto> GetAllProduct()
        {
             
            var Products = _productRepository.GetAll(false);    

            var ProductDto = Products.Select(P => P.ToProductDto());
            return ProductDto;
        }

        public ProductDetialsDto? GetProductById(int id)
        {
            var Product = _productRepository.GetById(id);

            return Product is null ? null : Product.ToProductDetailDto();
        }

        public int CreatedProductDto(CreateProductDto productDto)
        {
            var Products = productDto.ToEntity();

            return _productRepository.Add(Products);
        }

        public bool DeleteProduct(int id)
        {
            var Product = _productRepository.GetById(id);
            if (Product is null) return false;
            else
            {
                Product.IsDeleted = true;
                return _productRepository.Update(Product) > 0 ? true : false;
            }
        }

        public int UpdateProduct(UpdatedProductDto updatedProduct)
        {
            return _productRepository.Update(updatedProduct.ToEntity());
        }
    }
}
