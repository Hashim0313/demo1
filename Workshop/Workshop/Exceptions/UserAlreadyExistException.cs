namespace Workshop.Exceptions
{
    public class UserAlreadyExistException
    {
        public UserAlreadyExistException() { }

        public UserAlreadyExistException(string email) : base(String.Format(" user already exists ", email))
        {

        }
    }
}
