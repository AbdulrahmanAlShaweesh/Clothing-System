

using ClothingStore.DataAccess.Data.DbContexts;
using ClothingStore.DataAccess.Models.CategoryModel;
using ClothingStore.DataAccess.Repositories.GenericReposit;

namespace ClothingStore.DataAccess.Repositories.CategoryRepository
{
    public class CategoryRepository(ApplicationDbContext dbContext) : GenericRepository<Category>(dbContext) , ICategoryRepository
    {
    }
}



