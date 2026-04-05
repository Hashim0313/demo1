using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razortask1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Razortask1.Enums;


namespace Razortask1.Pages
{
    public class PatientProfileModel : PageModel
    {
        public string ProfileName { get; set; }



        public string ProfileRole { get; set; }


        private readonly Razortask1Context _context;


        public PatientProfileModel (Razortask1Context context)
        {
            _context = context;
        }


        public void OnGet()
        {
            ProfileName = HttpContext.Session.GetString("Name");
            ProfileRole = HttpContext.Session.GetString("Role");
        }


    }
}
