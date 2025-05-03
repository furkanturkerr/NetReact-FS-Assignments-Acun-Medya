using Core.Entities;

namespace Entities;

public class Blacklist : BaseEntity<Guid>
{
    public string Reason { get; set; }
    public DateTime Date { get; set; }
    public int ApplicantId { get; set; }

    public Blacklist() { }

    public Blacklist(Guid id, string reason, DateTime date, int applicantId)
    {
        Id = id;
        Reason = reason;
        Date = date;
        ApplicantId = applicantId;
    }
}
