using AutoMapper;
using Business.DTOs.Bootcamp;
using Business.Services.Interfaces;
using DTOs.Bootcamp;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Implementations
{
    public class BootcampManager : IBootcampService
    {
        private readonly DbContext _context;
        private readonly IMapper _mapper;

        public BootcampManager(DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<BootcampResponse>> GetAllAsync()
        {
            var bootcamps = await _context.Set<Bootcamp>().ToListAsync();
            return _mapper.Map<List<BootcampResponse>>(bootcamps);
        }

        public async Task<BootcampResponse> GetByIdAsync(int id)
        {
            var bootcamp = await _context.Set<Bootcamp>().FindAsync(id);
            return _mapper.Map<BootcampResponse>(bootcamp);
        }

        public async Task<BootcampResponse> AddAsync(BootcampRequest request)
        {
            var entity = _mapper.Map<Bootcamp>(request);
            await _context.Set<Bootcamp>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<BootcampResponse>(entity);
        }

        public async Task<BootcampResponse> UpdateAsync(int id, BootcampRequest request)
        {
            var entity = await _context.Set<Bootcamp>().FindAsync(id);
            if (entity == null) throw new Exception("Bootcamp not found");

            _mapper.Map(request, entity);
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<BootcampResponse>(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<Bootcamp>().FindAsync(id);
            if (entity == null) throw new Exception("Bootcamp not found");

            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
    