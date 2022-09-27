using Comet.Persistence.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Comet.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly CometDbContext dbContext;

        public  GenericRepository(CometDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public virtual async Task<T> Get(int id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public virtual async Task<T> Add(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            return entity;
        }
        public virtual async Task<T> Update(T entity)
        {
            dbContext.Set<T>().Update(entity);
            return entity;
        }

        public virtual async Task<bool> Delete(int id)
        {
            try
            {
                var entity = await dbContext.Set<T>().FindAsync(id);
                if (entity != null)
                {
                    dbContext.Set<T>().Remove(entity);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
