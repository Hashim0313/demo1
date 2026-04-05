using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using session.Models;

namespace session.Pages.Userpage
{
    public class ProfileModel : PageModel
    {
       public string ProfileName { get; set; }

        public void OnGet()
        {
            ProfileName = HttpContext.Session.GetString("User");
        }

    }
}
