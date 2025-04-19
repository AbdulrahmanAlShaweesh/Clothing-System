
using ClothingStore.DataAccess.Shared.Classess;

namespace ClothingStore.DataAccess.Repositories.GenericRepository.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity 
    {
        // Contracts 
        IEnumerable<TEntity> GetAll(bool WithTracking);       
        TEntity? GetById(int id);
        int Add(TEntity entity);
        int Update(TEntity entity); 
        int Remove(TEntity entity);
    }
}


