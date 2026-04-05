using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.Enums;
namespace Exercise.Models
{
    public class User
    {
        public int Id;
        public string? FirstName;
        public string? LastName;
        public string Email;
        public string Phone;
        public string Password;
        public Role Roles;


        public User(int id, string firstname,string lastname,string email,string phone,string password,Role roles)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone=phone;
            Password = password;
            Roles = roles;
    }
    }
}
