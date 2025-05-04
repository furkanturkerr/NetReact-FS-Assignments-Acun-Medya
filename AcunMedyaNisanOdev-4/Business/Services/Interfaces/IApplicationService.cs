using DTOs.Application;

namespace Business.Services.Interfaces;

public interface IApplicationService
{
    Task<List<ApplicationResponse>> GetAllAsync();
    Task<ApplicationResponse> GetByIdAsync(int id);
    Task AddAsync(ApplicationRequest request);
    Task UpdateAsync(int id, ApplicationRequest request);
    Task DeleteAsync(int id);
}