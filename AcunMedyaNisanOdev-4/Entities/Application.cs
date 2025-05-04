using Entities.Enums;

namespace Entities;

public class Application
{
    public Application(int id, int applicantId, int bootcampId, ApplicationState applicationState, DateTime createdDate)
    {
        Id = id;
        ApplicantId = applicantId;
        BootcampId = bootcampId;
        ApplicationState = applicationState;
        CreatedDate = createdDate;
    }

   public Application() { }

    public int Id { get; set; }
    public int? ApplicantId { get; set; }
    public int? BootcampId { get; set; }
    public ApplicationState ApplicationState { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
