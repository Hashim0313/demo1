using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razortask1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Razortask1.Enums;

namespace Razortask1.Pages
{
    public class AdminProfileModel : PageModel
    {
        public string ProfileName { get; set; }
        public string ProfileRole { get; set; }
        
        public int DocCount { get; set; }

        public int AppoCount { get; set; }




        private readonly Razortask1Context _context;

        public AdminProfileModel(Razortask1Context context)
        {
            _context = context;
        }



        public void OnGet()
        {
            ProfileName = HttpContext.Session.GetString("Name");

            ProfileRole = HttpContext.Session.GetString("Role");


            AppoCount = _context.Appointments.Count();
            DocCount = _context.Doctors.Count();



        }
       
    }
}
 