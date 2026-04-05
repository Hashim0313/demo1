using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razortask1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Razortask1.Pages.Appointmentpage
{
    public class UpdateApModel : PageModel
    {
        private readonly Razortask1Context _context;




        public UpdateApModel(Razortask1Context context)
        {
            _context = context;
        }


        [BindProperty]

        public Appointment Appointments { get; set; }


        public List<SelectListItem> DoctorList { get;set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Appointments = await _context.Appointments.FindAsync(id);

            //if (Appointments == null)
            //{
            //    return NotFound();
            //}


            DoctorList = await _context.Doctors.Select(d => new SelectListItem
            {
                Value = d.DoctorId.ToString(),
                Text = d.Name
            }).ToListAsync();

            return Page();

        }



        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }


        //    var apoupdate = await _context.Appointments.FindAsync(Appointments.AppointmentId);

        //    if (apoupdate == null)
        //    {
        //        return NotFound();
        //    }


        //    apoupdate.PatientName = Appointments.PatientName;
        //    apoupdate.AppointmentDate = Appointments.AppointmentDate;



        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                DoctorList = await _context.Doctors.Select(d => new SelectListItem
                {
                    Value = d.DoctorId.ToString(),
                    Text = d.Name
                }).ToListAsync();

                return Page();
            }

            var Apoupdate = await _context.Appointments.FindAsync(Appointments.AppointmentId);

        if (Apoupdate == null)
            {
            return NotFound();
            }

            Apoupdate.PatientName = Appointments.PatientName;
            Apoupdate.AppointmentDate = Appointments.AppointmentDate;
            Apoupdate.DoctorId = Appointments.DoctorId;


                await _context.SaveChangesAsync();

            return RedirectToPage("ReadAp");



        }
    }
}
    
