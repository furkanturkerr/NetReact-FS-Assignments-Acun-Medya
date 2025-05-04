using DTOs.Blacklist;
using Entities;

namespace Business.Services.Interfaces;

public interface IBlacklistService
{
    Task<IEnumerable<Blacklist>> GetAllAsync();
    Task<Blacklist> GetByIdAsync(int id);
    Task AddAsync(Blacklist entity);
    Task UpdateAsync(Blacklist entity);
    Task DeleteAsync(Blacklist entity);
}
