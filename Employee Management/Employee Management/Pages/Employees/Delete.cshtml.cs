using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Employee_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management.Pages.Employees
{
    public class DeleteModel : PageModel
    {
        private readonly EmployeeDbContext _context;


        public DeleteModel (EmployeeDbContext context)
        {
            _context = context;
        }

        [BindProperty]

        public Employee1 Employee { get; set; }

        public async Task <IActionResult> OnGetAsync(int ID)
        {
            Employee = await _context.Employees.FindAsync(ID);

            if (Employee == null)
            {
                return NotFound();
            }

            return Page();

        }


        public async Task <IActionResult> OnPostAsync()
        {
            var employee = await _context.Employees.FindAsync(Employee.ID);

            if(employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");

        }





    }
}
