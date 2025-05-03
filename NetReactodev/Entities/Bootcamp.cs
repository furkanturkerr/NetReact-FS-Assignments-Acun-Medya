using Core.Entities;
using Entities.Enums;

namespace Entities;

public class Bootcamp : BaseEntity<Guid>
{
    public string Name { get; set; }
    public int InstructorId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public BootcampState BootcampState { get; set; }

    public Bootcamp() { }

    public Bootcamp(Guid id, string name, int instructorId, DateTime startDate, DateTime endDate, BootcampState bootcampState)
    {
        this.Id = id;
        Name = name;
        InstructorId = instructorId;
        StartDate = startDate;
        EndDate = endDate;
        BootcampState = bootcampState;
    }
}
