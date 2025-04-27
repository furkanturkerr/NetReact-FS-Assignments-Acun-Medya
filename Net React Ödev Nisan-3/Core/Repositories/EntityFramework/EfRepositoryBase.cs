using Microsoft.EntityFrameworkCore;

namespace Core.Repositories
{
    public class EfRepositoryBase<T> : IAsyncRepository<T> where T : class
    {
        protected readonly DbContext Context;

        public EfRepositoryBase(DbContext context)
        {
            Context = context;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Context.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await Context.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await Context.Set<T>().AddAsync(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            Context.Set<T>().Update(entity);
            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();
        }
    }
}
