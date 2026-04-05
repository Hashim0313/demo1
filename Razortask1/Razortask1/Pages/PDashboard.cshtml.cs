using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razortask1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Razortask1.Enums;



namespace Razortask1.Pages
{
    public class PDashboardModel : PageModel
    {
        private readonly Razortask1Context _context;


        public PDashboardModel (Razortask1Context context)
        {
            _context = context;
        }

        public IList<Doctor> DoctorList { get; set; }

        public async Task OnGetAsync()
        {
            DoctorList = await _context.Doctors.ToListAsync();
        }





    }
}
