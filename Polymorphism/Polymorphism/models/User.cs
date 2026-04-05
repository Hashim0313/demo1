using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphismactivity.models
{
    public class User
    {
        public void Login()
        {
                       Console.WriteLine("User logged in");
        }

        public void Login(string username)
        {
                                  Console.WriteLine($"User {username} logged in");
        }
    }
}
