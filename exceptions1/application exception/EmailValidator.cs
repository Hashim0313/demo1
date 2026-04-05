using application_exception.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace application_exception
{
    internal class EmailValidator
    {
        public static void ValidateEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email,pattern))
            {
                throw new InvalidEmailExcp($"invalid emil address : {email}");
            }
        }
    }
}
