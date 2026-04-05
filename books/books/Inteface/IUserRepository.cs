using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using books.Models;

namespace books.Inteface
{
    public interface IUserRepository
    {
        public void Register();
        public User Login();
    }
}
