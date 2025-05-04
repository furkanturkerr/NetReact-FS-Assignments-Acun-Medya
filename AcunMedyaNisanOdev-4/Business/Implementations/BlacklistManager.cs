using Business.Services.Interfaces;
using Entities;
using Repositories.Interfaces;

namespace Business.Implementations
{
    public class BlacklistManager : IBlacklistService
    {
        private readonly IBlacklistRepository _blacklistRepository;

        public BlacklistManager(IBlacklistRepository blacklistRepository)
        {
            _blacklistRepository = blacklistRepository;
        }

        public async Task<IEnumerable<Blacklist>> GetAllAsync()
        {
            return await _blacklistRepository.GetAllAsync();
        }

        public async Task<Blacklist> GetByIdAsync(int id)
        {
            return await _blacklistRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Blacklist entity)
        {
            await _blacklistRepository.AddAsync(entity);
        }

        public async Task UpdateAsync(Blacklist entity)
        {
            await _blacklistRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(Blacklist entity)
        {
            await _blacklistRepository.DeleteAsync(entity);
        }
    }
}
