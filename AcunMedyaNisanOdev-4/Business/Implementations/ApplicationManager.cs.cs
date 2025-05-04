using AutoMapper;
using Business.Services.Interfaces;
using DTOs.Application;
using Entities;

namespace Business.Implementations;

public class ApplicationManager : IApplicationService
{
    private readonly IMapper _mapper;
    private static List<Application> _applications = new();

    public ApplicationManager(IMapper mapper)
    {
        _mapper = mapper;
    }

    public Task<List<ApplicationResponse>> GetAllAsync()
    {
        var result = _mapper.Map<List<ApplicationResponse>>(_applications);
        return Task.FromResult(result);
    }

    public Task<ApplicationResponse> GetByIdAsync(int id)
    {
        var app = _applications.FirstOrDefault(x => x.Id == id);
        var response = _mapper.Map<ApplicationResponse>(app);
        return Task.FromResult(response);
    }

    public Task AddAsync(ApplicationRequest request)
    {
        var entity = _mapper.Map<Application>(request);
        entity.Id = _applications.Count + 1;
        entity.CreatedDate = DateTime.Now;
        _applications.Add(entity);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(int id, ApplicationRequest request)
    {
        var app = _applications.FirstOrDefault(x => x.Id == id);
        if (app != null)
        {
            app.ApplicantId = request.ApplicantId;
            app.BootcampId = request.BootcampId;
            app.ApplicationState = request.ApplicationState;
        }
        return Task.CompletedTask;
    }

    public Task DeleteAsync(int id)
    {
        var app = _applications.FirstOrDefault(x => x.Id == id);
        if (app != null)
            _applications.Remove(app);
        return Task.CompletedTask;
    }
}
