using Entities;

namespace Repositories.Interfaces;

public interface IApplicationRepository : IRepository<Application>
{
    // Özel sorgular
    Task<IEnumerable<Application>> GetByApplicantIdAsync(int applicantId);
    Task<Application> GetByApplicantAndBootcampAsync(int applicantId, int bootcampId);
}
