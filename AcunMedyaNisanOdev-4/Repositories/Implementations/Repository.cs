using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using System.Linq.Expressions;

namespace Repositories.Implementations;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly ApplicationDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(ApplicationDbContext ctx)
    {
        _context = ctx;
        _dbSet = _context.Set<T>();
    }

    public async Task<T> GetByIdAsync(int id) => await _dbSet.FindAsync(id);
    public async Task<List<T>> GetAllAsync() => await _dbSet.ToListAsync();
    public async Task AddAsync(T entity) { await _dbSet.AddAsync(entity); await _context.SaveChangesAsync(); }
    public async Task UpdateAsync(T entity) { _dbSet.Update(entity); await _context.SaveChangesAsync(); }
    public async Task DeleteAsync(T entity) { _dbSet.Remove(entity); await _context.SaveChangesAsync(); }
    public async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate) => await _dbSet.AnyAsync(predicate);
}
