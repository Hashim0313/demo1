using blazortask1.Dto;
using blazortask1.Model;

namespace blazortask1.Interface
{
    public interface IEmployeeRepository
    {

        public Task<List<Employee>> GetEmployeeAsync();


        public Task<Employee> GetEmployeeByIdAsync(int id);


        public Task AddEmployeeAsync(Employee employee);




        public Task UpdateEmployeeAsync(int id ,Employee employee);


        public Task DeleteEmployeeAsync(int id);

    }
}
