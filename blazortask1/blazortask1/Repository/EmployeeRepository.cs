using blazortask1.Interface;
using blazortask1.Model;
using Microsoft.EntityFrameworkCore;

namespace blazortask1.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly AppDbContext _context;


        public EmployeeRepository (AppDbContext context)
        {
            _context = context;
        }




        public async Task <List<Employee>> GetEmployeeAsync()
        {
            return await _context.Employees.ToListAsync();
        }




        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }




        public async Task AddEmployeeAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }




        public async Task UpdateEmployeeAsync(int id, Employee employee)
        {

            var existingEmp = await _context.Employees.FindAsync(id);

            if(existingEmp==null)
            {
                return;
            }

            _context.Entry(existingEmp).State = EntityState.Detached;

            var updatedEmployee = employee;
            updatedEmployee.ID = id;


            _context.Employees.Attach(updatedEmployee);
            _context.Entry(updatedEmployee).State = EntityState.Modified;
             await _context.SaveChangesAsync();
            
        }



        public async Task DeleteEmployeeAsync(int id)
        {

            var employee = await _context.Employees.FindAsync(id);

            if(employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }

        }




    }
}
