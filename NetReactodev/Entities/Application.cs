using Core.Entities;
using Entities.Enums;

namespace Entities;

public class Application : BaseEntity<Guid>
{
    public int Id { get; set; }
    public string ApplicantId{ get; set; }
    public string BootcampId { get; set; }
    public ApplicationState ApplicationState { get; set; }

    public Application() { }

    public Application(Guid ıd, string applicantId, string bootcampId, ApplicationState applicationState)
    {
        ApplicantId = applicantId;
        BootcampId = bootcampId;
        this.ApplicationState = applicationState;
    }
}
