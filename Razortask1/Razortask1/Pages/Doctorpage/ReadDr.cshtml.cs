using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razortask1.Models;
using Microsoft.EntityFrameworkCore;


namespace Razortask1.Pages.Doctorpage
{
    public class ReadDrModel : PageModel
    {

        private readonly Razortask1Context _context;
        

        [BindProperty  (SupportsGet=true)]
        public string SearchTerm { get; set; }



        public ReadDrModel (Razortask1Context context)
        {
            _context = context;
        }

        public IList <Doctor> DocList { get; set; }

        public IList<Appointment> ApoList { get; set; } = new List<Appointment>();

        public async Task OnGetAsync()
        {
            DocList = await _context.Doctors.ToListAsync();



            var query = _context.Doctors.AsQueryable();

            if (!string.IsNullOrWhiteSpace(SearchTerm))
            {
                query = query.Where(e =>
                    e.Name.Contains(SearchTerm));
                   
            }

            DocList = await query.ToListAsync();

        }



    }
}
