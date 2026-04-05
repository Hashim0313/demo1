using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using session.Models;

namespace session.Pages.Userpage
{
    public class RegisterModel : PageModel
    {

        private readonly UserDbContext _context;

        [BindProperty]

        public User NewUser { get; set; }

        public RegisterModel(UserDbContext context)
        {
            _context = context;
        }



        public IActionResult OnPost()
        {
            if(string.IsNullOrEmpty(NewUser.Username) || string.IsNullOrEmpty(NewUser.Password))
            {
                ModelState.AddModelError("", "Username and password are required");
                return Page();
            }


            if(_context.Users.Any(u => u.Username == NewUser.Username))
            {
                ModelState.AddModelError("", "Username already taken");
                return Page();
            }

            _context.Users.Add(NewUser);
            _context.SaveChanges();
            return RedirectToPage("Login");



        }




    }
}
