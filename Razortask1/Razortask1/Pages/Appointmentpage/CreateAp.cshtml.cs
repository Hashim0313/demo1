using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Razortask1.Models;

namespace Razortask1.Pages.Appointmentpage
{
    public class CreateApModel : PageModel
    {


        private readonly Razortask1Context _context;

        [BindProperty]

        public Appointment Appointments { get; set; }

        public List<SelectListItem> DoctorList { get; set; }

        public string uid { get; set; }

        public CreateApModel (Razortask1Context context)
        {
            _context = context;
        }



        public void OnGetAsync()
        {
            DoctorList = _context.Doctors.Select(d => new SelectListItem
            {

                Value = d.DoctorId.ToString(),
                Text = d.Name

            }).ToList();
            uid = HttpContext.Session.GetInt32("UserID")?.ToString();

        }






        public IActionResult OnPostAsync()
        {
            
                OnGetAsync();
               

            Appointments.UserID =int.Parse(uid);

            _context.Appointments.Add(Appointments);
            _context.SaveChanges();
            return RedirectToPage("ReadAp");
          


        }


    }
}
