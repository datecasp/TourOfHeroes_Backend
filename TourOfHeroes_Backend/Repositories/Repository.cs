using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TourOfHeroes_Backend.DataContext;
using TourOfHeroes_Backend.Models;

namespace TourOfHeroes_Backend.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly Context Db;

        protected readonly DbSet<TEntity> DbSet;

        protected Repository(Context db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            DbSet.AddAsync(entity);
            Db.SaveChanges();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            var entity = await DbSet.FindAsync(id);

            if (entity == null)
            {
                return null;
            }

            return entity;
        }

        public async Task<bool> Update(TEntity entity)
        {
            if (EntityExists(entity))
            {
                DbSet.Update(entity);
                await Db.SaveChangesAsync();
                return true;
            }
            else { return false; }
        }

        public async Task Remove(TEntity entity)
        {
            if (EntityExists(entity))
            {
                DbSet.Remove(entity);
            }
            await SaveChanges();
        }

        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public bool EntityExists(TEntity entity)
        {
            return DbSet.Any(e => e.HeroId == entity.HeroId);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
