using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryManagement.Models;

namespace LibraryManagement.Pages.Books
{
    public class DeleteModel : PageModel
    {
        private readonly LibraryManagementContext _context;


        public DeleteModel (LibraryManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Bookss{ get; set; }


        public async Task <IActionResult>OnGetAsync(int id)
        {
            Bookss = await _context.Books.FindAsync(id);

            if(Bookss == null)
            {
                return NotFound();
            }

            return Page();

        }


        public async Task <IActionResult>OnPostAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }


            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");


        }






    }
}
