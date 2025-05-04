using Entities.Enums;

namespace DTOs.Application;

public class ApplicationResponse
{
    public int Id { get; set; }
    public int ApplicantId { get; set; }
    public int BootcampId { get; set; }
    public ApplicationState ApplicationState { get; set; }
    public DateTime CreatedDate { get; set; }
}
