using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razortask1.Models;


namespace Razortask1.Pages.Appointmentpage
{
    public class ReadApModel : PageModel
    {
        private readonly Razortask1Context _context;


        public ReadApModel(Razortask1Context context)
        {
            _context = context;
        }



        [BindProperty (SupportsGet=true)]

        public string SearchTerm { get; set; }




        public IList <Doctor> DocList { get; set; }

        public IList <Appointment> AppoList { get; set; }

        public async Task OnGetAsync()
        {
           var UID = HttpContext.Session.GetInt32("UserID");

            var UROl = HttpContext.Session.GetString("Roles");


          




            if (UROl == "ADMIN")
            {

                DocList = await _context.Doctors.Include(i => i.Appointments).ToListAsync();
            }

            if(UROl == "PATIENT")
            {
                DocList = await _context.Doctors.Include(i => i.Appointments.Where(u => u.UserID == UID)).ToListAsync();
            }



            //var query = _context.Doctors.AsQueryable();

            //if (!string.IsNullOrWhiteSpace(SearchTerm))
            //{
            //    query = query.Where(e =>

            //    e.Name.Contains(SearchTerm));
            //}

            //DocList = await query.ToListAsync();



            var query = _context.Appointments.AsQueryable();


            if (!string.IsNullOrWhiteSpace(SearchTerm))
            {
                query = query.Where(e => e.PatientName.Contains(SearchTerm));
            }

            AppoList = await query.ToListAsync();



        }







        }



      

      


    }

