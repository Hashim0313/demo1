using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Employee_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management.Pages.Employee
{
    public class IndexModel : PageModel
    {

        private readonly EmployeeDbContext _context;


        public IndexModel(EmployeeDbContext context)
        {
            _context = context;
        }


        public IList<Employee1> EmployeeList { get; set; }









        public async Task OnGetAsync()
        {
            EmployeeList = await _context.Employees.ToListAsync();
        }
    }
}
