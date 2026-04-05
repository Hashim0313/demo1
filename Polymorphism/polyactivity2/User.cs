using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyactivity2
{
    public class User
    {
        public int Id;
        public string Email;
        public string Password;

        public virtual void Login()
        {
            Console.WriteLine("User logged in");
        }
    }


    public class  Jobprovider:User
    {
        public string CompanyName;

        public override void Login()
        {
            Console.WriteLine("Job provider logged in");
        }
    }

    public class Jobseeker:User
    {
        public string Qualification;
        public override void Login()
        {
            Console.WriteLine("Job seeker logged in");
        }
    }
}
