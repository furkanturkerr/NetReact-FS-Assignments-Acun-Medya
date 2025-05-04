using Repositories.Interfaces;
using DataAccess.Context;
using Entities;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Repositories.Implementations
{
    public class BlacklistRepository : Repository<Blacklist>, IBlacklistRepository
    {
        public BlacklistRepository(ApplicationDbContext ctx) : base(ctx) { }
        public async Task<IEnumerable<Blacklist>> GetByApplicantIdAsync(int applicantId)
            => await _context.Blacklists.Where(b => b.ApplicantId == applicantId).ToListAsync();
        public async Task<bool> IsBlacklistedAsync(int applicantId)
            => await _context.Blacklists.AnyAsync(b => b.ApplicantId == applicantId);
    }
}


