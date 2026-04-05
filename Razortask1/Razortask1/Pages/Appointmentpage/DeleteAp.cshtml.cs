using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razortask1.Models;
using Microsoft.EntityFrameworkCore;


namespace Razortask1.Pages.Appointmentpage
{
    public class DeleteApModel : PageModel
    {
        public readonly Razortask1Context _context;


        public DeleteApModel (Razortask1Context context)
        {
            _context = context;
        }


        [BindProperty]

        public Appointment Appointmentd { get; set; }


        public Doctor doctor { get; set; }



        public async Task <IActionResult> OnGetAsync(int id)
        {
            Appointmentd = await _context.Appointments.FindAsync(id);


            doctor = _context.Doctors.SingleOrDefault(D => D.DoctorId == Appointmentd.DoctorId);



            if (Appointmentd == null)
            {
                return NotFound();
            }

            return Page();

        }



        public async Task <IActionResult> OnPostAsync()
        {

            var appos = await _context.Appointments.FindAsync(Appointmentd.AppointmentId);

            if(appos == null)
            {
                return NotFound();
            }



            _context.Appointments.Remove(appos);
            await _context.SaveChangesAsync();

            return RedirectToPage("ReadAp");


        }



    }
}
