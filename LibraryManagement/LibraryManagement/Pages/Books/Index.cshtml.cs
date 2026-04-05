using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryManagement.Models;

namespace LibraryManagement.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly LibraryManagementContext _context;


        public IndexModel(LibraryManagementContext context )
        {
            _context = context;
        }

        public IList < Book > BookList { get; set; }


        public async Task OnGetAsync()
        {
            BookList = await _context.Books.ToListAsync();
        }


    }
}
