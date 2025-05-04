using Entities.Enums;

namespace Business.DTOs.Bootcamp;
public  class BootcampRequest
{
    public string Name { get; set; }
    public int InstructorId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public BootcampState BootcampState { get; set; }
}
