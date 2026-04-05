using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Employee_Management.Models;
using Microsoft.EntityFrameworkCore;


namespace Employee_Management.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly EmployeeDbContext _context;

        [BindProperty]


        public Employee1 Employee { get; set; }


        public CreateModel (EmployeeDbContext context)
        {
            _context = context;
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Employees.Add(Employee);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }


    }
}
