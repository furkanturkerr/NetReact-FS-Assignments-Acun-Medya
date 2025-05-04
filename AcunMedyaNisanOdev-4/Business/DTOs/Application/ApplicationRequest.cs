using Entities.Enums;

namespace DTOs.Application;

public class ApplicationRequest
{
    public int ApplicantId { get; set; }
    public int BootcampId { get; set; }
    public ApplicationState ApplicationState { get; set; }
}