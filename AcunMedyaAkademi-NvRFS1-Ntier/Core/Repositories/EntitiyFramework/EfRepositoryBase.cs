using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Core.Repositories.EntitiyFramework;

public class EfRepositoryBase<TEntity, TEntityId, TContext> : IRepository<TEntity, TEntityId>
    where TEntity : BaseEntitiy<TEntityId>
    where TContext : DbContext
{

    protected readonly TContext Context;
    public EfRepositoryBase(TContext context)
    {
        Context = context;
    }

    public IQueryable<TEntity> Query() => Context.Set<TEntity>();

    TEntity IRepository<TEntity, TEntityId>.Add(TEntity entity)
    {
        entity.CreatedDate = DateTime.UtcNow;
        Context.Add(entity);
        Context.SaveChanges();
        return entity;
    }

    TEntity IRepository<TEntity, TEntityId>.Delete(TEntity entity)
    {
        entity.DeletedDate = DateTime.UtcNow;
        Context.Remove(entity);
        Context.SaveChanges();
        return entity;
    }

    TEntity IRepository<TEntity, TEntityId>.Get(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include)
    {
        IQueryable<TEntity> queryable = Query();
        if (include != null)
            queryable = include(queryable);
        return queryable.FirstOrDefault(predicate);
    }

    List<TEntity> IRepository<TEntity, TEntityId>.GetAll(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include)
    {
        IQueryable<TEntity> queryable = Query();
        if (include != null)
            queryable = include(queryable);
        if (predicate != null)
            queryable = queryable.Where(predicate);
        return queryable.ToList();

    }

    IQueryable<TEntity> IQuery<TEntity>.Query()
    {
        throw new NotImplementedException();
    }

    TEntity IRepository<TEntity, TEntityId>.Uptade(TEntity entity)
    {
        entity.DeletedDate = DateTime.UtcNow;
        Context.Update(entity);
        Context.SaveChanges();
        return entity;    
    }
}
