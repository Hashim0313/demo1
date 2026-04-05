using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razortask1.Pages
{
    public class ProfileModel : PageModel
    {


        public string ProfileName { get; set; }

        public void OnGet()
        {
            ProfileName = HttpContext.Session.GetString("Name");
        }
    }
}
