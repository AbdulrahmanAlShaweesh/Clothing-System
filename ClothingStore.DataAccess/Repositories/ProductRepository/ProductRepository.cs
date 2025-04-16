using ClothingStore.DataAccess.Data.DbContexts;
using ClothingStore.DataAccess.Models.ProductModel;
using ClothingStore.DataAccess.Repositories.GenericReposit;


namespace ClothingStore.DataAccess.Repositories.ProductRepository
{
    class ProductRepository(ApplicationDbContext dbContext) : GenericRepository<Product>(dbContext) , IProductRepository
    {
    }
}
