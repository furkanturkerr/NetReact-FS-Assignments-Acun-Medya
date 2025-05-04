using Entities;

namespace Repositories.Interfaces
{
    public interface IApplicationRepository : IRepository<Application>
    {
        Task<IEnumerable<Application>> GetByApplicantIdAsync(int applicantId);
        Task<Application> GetByApplicantAndBootcampAsync(int applicantId, int bootcampId);
    }
}
