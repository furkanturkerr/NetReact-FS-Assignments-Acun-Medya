
namespace Core.Repositories.EntityFramework;

public class EfRepositoryBase<T> : IAsyncRepository<T> where T : class
{
    Task<T> IAsyncRepository<T>.AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    Task IAsyncRepository<T>.DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    Task<IReadOnlyList<T>> IAsyncRepository<T>.GetAllAsync()
    {
        throw new NotImplementedException();
    }

    Task<T> IAsyncRepository<T>.GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    Task IAsyncRepository<T>.UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
