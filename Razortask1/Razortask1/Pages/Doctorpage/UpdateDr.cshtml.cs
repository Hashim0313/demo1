using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razortask1.Models;
using Microsoft.EntityFrameworkCore;

namespace Razortask1.Pages.Doctorpage
{
    public class UpdateDrModel : PageModel
    {
        private readonly Razortask1Context _context;


        public UpdateDrModel (Razortask1Context context)
        {
            _context = context;
        }


        [BindProperty]


        public Doctor Doctors { get; set; }

        public async Task <IActionResult> OnGetAsync(int Id)
        {
            Doctors = await _context.Doctors.FindAsync(Id);

            if(Doctors == null)
            {
                return NotFound();
            }

            return Page();


        }



        public async Task <IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            var updoc = await _context.Doctors.FindAsync(Doctors.DoctorId);

            if(updoc == null)
            {
                return NotFound();
            }


            updoc.Name = Doctors.Name;
            updoc.Specialization = Doctors.Specialization;

            await _context.SaveChangesAsync();

            return RedirectToPage("ReadDr");




        }










    }
}
