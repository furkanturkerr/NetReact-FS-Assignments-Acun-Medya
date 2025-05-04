using Business.DTOs.Application;
using Business.Services.Interfaces;
using Entities;
using Repositories.Interfaces;

namespace Business.Services.Implementations
{
    public class ApplicationService : IApplicationService
    {
        private readonly IRepository<Application> _repository;
        private readonly IMapper _mapper;

        public ApplicationService(IRepository<Application> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ApplicationDto> CreateAsync(CreateApplicationDto dto)
        {
            var entity = _mapper.Map<Application>(dto);
            await _repository.AddAsync(entity);
            return _mapper.Map<ApplicationDto>(entity);
        }
    }
}