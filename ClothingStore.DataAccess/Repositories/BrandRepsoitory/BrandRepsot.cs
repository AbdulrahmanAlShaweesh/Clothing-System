﻿


namespace ClothingStore.DataAccess.Repositories.BrandRepsoitory
{
    public class BrandRepsot(ApplicationDbContext dbContext) : GenericRepository<ProductBrand>(dbContext) , IBrandRepsotitory
    {
    }
}
