using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razortask1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Razortask1.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly Razortask1Context _context;


        [BindProperty]
        public User NewUser { get; set; }


        public RegisterModel(Razortask1Context context)
        {
            _context = context;
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(NewUser.Email) || string.IsNullOrEmpty(NewUser.Password) || string.IsNullOrEmpty(NewUser.Name))
            {
                ModelState.AddModelError("", "Email and Password are required");

                return Page();
            }
          



            if (_context.Users.Any(u => u.Email == NewUser.Email))
            {
                ModelState.AddModelError("", "Email already taken");
                return Page();
            }

            _context.Users.Add(NewUser);
            _context.SaveChanges();
            return RedirectToPage("Login");
    }

}



    }


