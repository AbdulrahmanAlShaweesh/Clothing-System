 
using ClothingStore.DataAccess.Services.DataTransferObject.ProductDtos;

namespace ClothingStore.BusinessLogic.Services.Product
{
   public interface IProductService
    {
        IEnumerable<ProductDto> GetAllProduct();
        ProductDetialsDto? GetProductById(int id); 
        int CreatedProductDto(CreateProductDto productDto);
        int UpdateProduct(UpdatedProductDto productDto);
        bool DeleteProduct(int id); 
    }
}
