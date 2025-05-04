using Entities.Enums;

namespace Entities;

public class Blacklist
{
    public Blacklist(int id, string reason, DateTime date, int applicantId)
    {
        Id = id;
        Reason = reason;
        Date = date;
        ApplicantId = applicantId;
    }

    public Blacklist() { }

    public int Id { get; set; }
    public string Reason { get; set; }
    public DateTime Date { get; set; }= DateTime.Now;
    public int ApplicantId { get; set; }

    public Application Application { get; set; }
}
