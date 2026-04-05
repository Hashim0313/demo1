using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Manager
{
    public class UserManager : IMenu
    {
        private User loggedUser;

        public UserManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }

        public UserManager() { }

        public void DisplayMenu()
        {
            throw new NotImplementedException();
        }
    }
}
