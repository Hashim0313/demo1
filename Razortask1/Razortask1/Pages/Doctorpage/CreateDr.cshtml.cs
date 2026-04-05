using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razortask1.Models;

namespace Razortask1.Pages.Doctorpage
{
    public class CreateDrModel : PageModel
    {
        private readonly Razortask1Context _context;


        [BindProperty]

        public Doctor Doctor { get; set; }

        public CreateDrModel (Razortask1Context context)
        {
            _context = context;
        }



        public  IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();


            _context.Doctors.Add(Doctor);
         

            _context.SaveChanges();

            return RedirectToPage("ReadDr");


        }

    }
}
