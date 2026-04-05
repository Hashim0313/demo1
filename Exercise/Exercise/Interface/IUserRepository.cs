using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.Models;

namespace Exercise.Interface
{
    public interface IUserRepository
    {
        public void  Register();
        public User Login();
    }
}
