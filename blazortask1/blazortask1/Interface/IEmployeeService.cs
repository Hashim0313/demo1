using blazortask1.Dto;

namespace blazortask1.Interface
{
    public interface IEmployeeService
    {

        public Task<List<EmployeeDto>> GetEmployeeAsync();


        public Task<EmployeeDto> GetEmployeeByIdAsync(int id);


        public Task AddEmployeeAsync(EmployeeDto empDto);


        public Task UpdateEmployeeAsync(int id ,EmployeeDto empDto);


        public Task DeleteEmployeeAsync(int id);

    }
}
