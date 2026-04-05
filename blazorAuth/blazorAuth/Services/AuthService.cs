using blazorAuth.Data;
using blazorAuth.Model;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;




namespace blazorAuth.Services
{
    public class AuthService
    {

        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContext;


        public AuthService(AppDbContext context , IHttpContextAccessor httpContext)
        {
            _context = context;
            _httpContext = httpContext;
        }



        public async Task<bool> Register (string username , string password , string email)
        {
            if (await _context.Users.AnyAsync(u => u.UserName == username)) return false;


            var user = new User
            {
                UserName = username,
                PasswordHash = HashPassword(password),
                Email = email
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return true;

        }



        public async Task <bool> Login (string username , string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);

            if (user == null || user.PasswordHash != HashPassword(password))

                return false;

            await Task.Run(() =>
            {

                var context = _httpContext.HttpContext;

                if (context != null)
                {

                    context.Session.SetString("UserId", user.ID.ToString());
                    context.Session.SetString("Username", user.UserName);
                    context.Session.SetString("Email", user.Email);

                }

            });

            return true;


        }



        public void Logout()
        {
            _httpContext.HttpContext.Session.Clear();
        }



        public string GetCurrentUser()
        {
            return _httpContext.HttpContext.Session.GetString("Username");
        }



        public bool IsLoggedIn()
        {
            return !string.IsNullOrEmpty(_httpContext.HttpContext.Session.GetString("UserId"));
        }




        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();

            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
           
            return Convert.ToBase64String(bytes);

        }



    }
}
