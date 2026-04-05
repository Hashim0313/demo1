using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibraryManagement.Models;

namespace LibraryManagement.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly LibraryManagementContext _context;


        [BindProperty]

        public Book Books { get; set; }

        public CreateModel (LibraryManagementContext context)
        {
            _context = context;
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();


            _context.Books.Add(Books);
            _context.SaveChanges();
            return RedirectToPage("Index");


        }
    }
}
