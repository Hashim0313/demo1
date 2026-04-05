using exercise_2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2.models
{
    public class User
    {
        public int Id;
        public string? FirstName;
        public string? LastName;
        public string Email = string.Empty;
        public string Phone = string.Empty;
        public string Password;
        public Roles Role;

        
        
    }
}
