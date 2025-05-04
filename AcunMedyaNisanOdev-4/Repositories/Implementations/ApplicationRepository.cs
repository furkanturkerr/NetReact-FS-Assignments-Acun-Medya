using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using DataAccess.Context;

namespace Repositories.Implementations
{
    public class ApplicationRepository : Repository<Application>, IApplicationRepository
    {
        public ApplicationRepository(ApplicationDbContext ctx) : base(ctx) { }
        public async Task<IEnumerable<Application>> GetByApplicantIdAsync(int applicantId)
            => await _context.Applications.Where(a => a.ApplicantId == applicantId).ToListAsync();
        public async Task<Application> GetByApplicantAndBootcampAsync(int applicantId, int bootcampId)
            => await _context.Applications.FirstOrDefaultAsync(a => a.ApplicantId == applicantId && a.BootcampId == bootcampId);
    }
}
