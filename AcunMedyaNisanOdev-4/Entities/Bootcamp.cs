using Entities.Enums;

namespace Entities;

public class Bootcamp
{
    public Bootcamp(int ıd, string name, int ınstructorId, DateTime startDate, DateTime endDate, BootcampState bootcampState)
    {
        Id = ıd;
        Name = name;
        InstructorId = ınstructorId;
        StartDate = startDate;
        EndDate = endDate;
        BootcampState = bootcampState;
    }

    public Bootcamp() { }

    public int Id { get; set; }
    public string Name { get; set; }
    public int InstructorId  { get; set; }
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime EndDate { get; set; } = DateTime.Now;
    public BootcampState BootcampState { get; set; }

}
