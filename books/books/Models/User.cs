using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using books.Enums;

namespace books.Models
{
    public class User
    {
        public int Id;
        public string Name;
        public Role Roles;
        public string Password;

        public User(int id, string name, Role roles,string password)
        {
            Id = id;
            Name = name;
            Roles = roles;
            Password = password;
        }
    }
}
