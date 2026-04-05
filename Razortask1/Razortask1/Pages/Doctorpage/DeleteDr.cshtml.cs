using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razortask1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Razortask1.Pages.Doctorpage
{
    public class DeleteDrModel : PageModel
    {
        private readonly Razortask1Context _context;



        public DeleteDrModel (Razortask1Context context)
        {
            _context = context;
        }

        [BindProperty]

        public Doctor Docs { get; set; }


        public List <SelectListItem> DoctorList { get; set; }


        public async Task <IActionResult> OnGetAsync(int id)
        {
            Docs = await _context.Doctors.FindAsync(id);

            //if (Docs == null)
            //{
            //    return NotFound();
            //}
            //


            DoctorList = await _context.Doctors.Select(d => new SelectListItem
            {
                Value = d.DoctorId.ToString(),
                Text = d.Name
            }).ToListAsync();
            return Page();
        }



        public async Task <IActionResult> OnPostAsync()
        {

            if(!ModelState.IsValid)
            {

                

            }

            var doc = await _context.Doctors.FindAsync();

            if (doc == null)
            {
                return NotFound();
            }


            _context.Doctors.Remove(doc);
            await _context.SaveChangesAsync();

            return RedirectToPage("ReadDr");

        }













    }
}
