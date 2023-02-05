using System.Linq.Expressions;

namespace TourOfHeroes_Backend.Models
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<TEntity> Add(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<bool> Update(TEntity entity);
        Task Remove(TEntity entity);
        Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate);
    }
}
