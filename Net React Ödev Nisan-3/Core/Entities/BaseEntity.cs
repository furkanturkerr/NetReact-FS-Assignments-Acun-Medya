using System.Security.Cryptography;

namespace Core.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
}
