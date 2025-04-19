
using ClothingStore.DataAccess.Data.DbContexts;
using ClothingStore.DataAccess.Repositories.GenericRepository.GenericRepository;
using ClothingStore.DataAccess.Shared.Classess;

namespace ClothingStore.DataAccess.Repositories.GenericReposit
{
    public class GenericRepository<TEntity>(ApplicationDbContext _dbContext) : IGenericRepository<TEntity> where TEntity : BaseEntity
    {

        public IEnumerable<TEntity> GetAll(bool WithTracking = false)
        {
            if (WithTracking) return _dbContext.Set<TEntity>().Where(P => P.IsDeleted != true).ToList();
            else return _dbContext.Set<TEntity>().AsNoTracking().Where(P => P.IsDeleted).ToList();
        }

        public TEntity? GetById(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public int Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            return _dbContext.SaveChanges();
        }

        public int Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            return _dbContext.SaveChanges();
        }

        public int Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            return _dbContext.SaveChanges();
        }
    }
}
