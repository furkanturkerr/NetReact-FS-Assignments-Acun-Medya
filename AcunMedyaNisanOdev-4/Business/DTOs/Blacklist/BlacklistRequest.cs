namespace DTOs.Blacklist;

public class BlacklistRequest
{
    public string Reason { get; set; }
    public DateTime Date { get; set; }
    public int ApplicantId { get; set; }
}
