using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Employee_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly EmployeeDbContext _context;

        public EditModel (EmployeeDbContext context)
        {
            _context = context;
        }

        [BindProperty]

        public Employee1 Employee { get; set; }


        public async Task<IActionResult> OnGetAsync(int ID)
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
            if (!ModelState.IsValid)
            {
                return Page();
            }


            var employeeToUpdate = await _context.Employees.FindAsync(Employee.ID);

            if (employeeToUpdate == null)
            {
                return NotFound();
            }


            employeeToUpdate.Name = Employee.Name;
            employeeToUpdate.Position = Employee.Position;
            employeeToUpdate.Salary = Employee.Salary;
            employeeToUpdate.Department = Employee.Department;


            await _context.SaveChangesAsync();

            return RedirectToPage("Index");


        }



    }
}
