using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryManagement.Models;

namespace LibraryManagement.Pages.Books
{
    public class EditModel : PageModel
    {
        private readonly LibraryManagementContext _context;

        public EditModel (LibraryManagementContext context)
        {
            _context = context;
        }



        [BindProperty]

        public Book Books { get; set; }

        public async Task <IActionResult> OnGetAsync(int ID)
        {
            Books = await _context.Books.FindAsync(ID);

            if (Books == null)
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


            var bookUpdate = await _context.Books.FindAsync(Books.BookId);

            if (bookUpdate == null)
            {
                return NotFound();
            }


            bookUpdate.Bookname = Books.Bookname;
            bookUpdate.Author = Books.Author;
            bookUpdate.Price = Books.Price;


            await _context.SaveChangesAsync();

            return RedirectToPage("Index");

        }

    }
}
