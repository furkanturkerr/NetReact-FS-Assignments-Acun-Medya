using Business.DTOs.Application;

namespace Business.Services.Interfaces
{
    public interface IApplicationService
    {
        Task<ApplicationDto> CreateAsync(CreateApplicationDto dto);
        Task<List<ApplicationDto>> GetAllAsync();
    }
}