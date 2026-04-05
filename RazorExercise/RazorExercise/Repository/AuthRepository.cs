using RazorExercise.Interface;
using RazorExercise.Models;

namespace RazorExercise.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly RazorExerciseContext _context;


        public AuthRepository (RazorExerciseContext context)
        {
            _context = context;
        }


        public async Task Register (User user)
        {


            _context.Users.Add(user);
            _context.SaveChanges();


        }


        public async Task <User> Login(User luser)
        {


            var loguser = _context.Users.SingleOrDefault(u => u.Email == luser.Email && u.Password == luser.Password);

            if (loguser == null)
            {
                return null;
            }
            return loguser;


        }


    }
}
