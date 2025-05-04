using DataAccess.Context;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Implementations
{
    public class BootcampRepository : Repository<Bootcamp>, IBootcampRepository
    {
        public BootcampRepository(ApplicationDbContext ctx) : base(ctx) { }
        public async Task<IEnumerable<Bootcamp>> GetByInstructorIdAsync(int instructorId)
            => await _context.Bootcamps.Where(b => b.InstructorId == instructorId).ToListAsync();
    }
}