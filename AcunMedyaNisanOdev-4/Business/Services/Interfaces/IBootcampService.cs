using Business.DTOs.Bootcamp;
using DTOs.Bootcamp;

namespace Business.Services.Interfaces;

public interface IBootcampService
{
    Task<List<BootcampResponse>> GetAllAsync();
    Task<BootcampResponse> GetByIdAsync(int id);
    Task<BootcampResponse> AddAsync(BootcampRequest request);
    Task<BootcampResponse> UpdateAsync(int id, BootcampRequest request);
    Task DeleteAsync(int id);
}
