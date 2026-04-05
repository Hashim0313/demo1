using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using session.Models;

namespace session.Pages.Userpage
{
    public class LoginModel : PageModel
    {
        private readonly UserDbContext _context;


        [BindProperty]

        public string Username { get; set; }

        [BindProperty]

        public string Password {get; set;}

        public LoginModel(UserDbContext context)
        {
            _context = context;
        }

        public IActionResult OnPost()
        {
            var user = _context.Users.SingleOrDefault(u => u.Username == Username && u.Password == Password);

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid username or password");
                return Page();
            }

            HttpContext.Session.SetString("User", Username);
            return RedirectToPage("Profile");

        }

    }
}
