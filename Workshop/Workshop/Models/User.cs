using Workshop.Enums;

namespace Workshop.Models
{
    public class User
    {
        public int Id;
        public string? FirstName;
        public string? LastName;
        public string Email;
        public long Phone;
        public Roles Role;
        public string Password;
        public User() { }

        public User(int id, string firstname, string lastname, string email, long phone, Roles role, string password)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
            Role = role;
            Password = password;
        }
    }
}
