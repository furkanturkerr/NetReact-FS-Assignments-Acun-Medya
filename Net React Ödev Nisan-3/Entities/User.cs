namespace Entities;
using Core.Entities;
public class User : BaseEntity
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string NationalIdentity { get; set; }
    public string Email { get; set; }
    public string Pasword { get; set; }

    public User()
    {

    }

    public User(int id, string username, string firstname, string lastname, DateTime dateofbirth, string nationalidentity, string email, string pasword)
    {
        Id = id;
        UserName = username;
        Firstname = firstname;
        Lastname = lastname;
        DateOfBirth = dateofbirth;
        NationalIdentity = nationalidentity;
        Email = email;
        Pasword = pasword;
    }


}