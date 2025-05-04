using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IBootcampRepository : IRepository<Bootcamp>
    {
        Task<IEnumerable<Bootcamp>> GetByInstructorIdAsync(int instructorId);
    }
}