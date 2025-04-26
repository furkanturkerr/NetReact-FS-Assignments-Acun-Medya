using Core.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Collections.Immutable;
using System.Linq.Expressions;

namespace Core.Repositories;

public interface IRepository<TEntity, TEntityId>: IQuery<TEntity>
    where TEntity : BaseEntitiy<TEntityId>// = Kullanılacak TEntity, BaseEntity'den türemiş olmalı.
{
    TEntity Add(TEntity entity);
    TEntity Uptade(TEntity entity);
    TEntity Delete(TEntity entity);
    List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null);

    TEntity Get(Expression<Func<TEntity, bool>> predicate, 
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null);

}

//Bu interface diyor ki:

//"Kim bu repository'i kullanıyorsa,
//mutlaka Add, Update, Delete fonksiyonlarını yazmak ZORUNDA!"