using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razortask1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Razortask1.Enums;

namespace Razortask1.Pages
{
    public class LoginModel : PageModel
    {

        private readonly Razortask1Context _context;





        [BindProperty]

        public string Email { get; set; }



        [BindProperty]

        public string Password { get; set; }








        public LoginModel(Razortask1Context context)
        {
            _context = context;
        }


        public IActionResult OnPost()
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == Email && u.Password == Password);
        
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid email or password");
                return Page();
            }

            HttpContext.Session.SetString("Name",user.Name);


            HttpContext.Session.SetString("Email",user.Email);

           
            HttpContext.Session.SetString("Roles", user.Role.ToString());
       

            HttpContext.Session.SetInt32("UserID",user.UserID);


            if (user.Role == Roles.PATIENT)
            {
                return RedirectToPage("/PatientProfile");
            }


            if (user.Role == Roles.ADMIN)
            {
                return RedirectToPage("AdminProfile");
            }

            return Page();
        }

    }
}
