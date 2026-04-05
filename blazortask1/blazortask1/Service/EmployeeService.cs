using AutoMapper;
using blazortask1.Dto;
using blazortask1.Interface;
using blazortask1.Model;
using blazortask1.Repository;

namespace blazortask1.Service
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IEmployeeRepository _empRepository;

        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository empRepository, IMapper mapper )
        {
            _empRepository = empRepository;
            _mapper = mapper;
        }



        public async Task<List<EmployeeDto>>GetEmployeeAsync ()
        {
            var employee=  await _empRepository.GetEmployeeAsync();
            return _mapper.Map<List<EmployeeDto>>(employee);
        }



        public async Task <EmployeeDto> GetEmployeeByIdAsync(int id)
        {
            var employee = await _empRepository.GetEmployeeByIdAsync(id);
            return _mapper.Map<EmployeeDto>(employee);

        }




        public async Task AddEmployeeAsync(EmployeeDto empDto)
        {
            var employee = _mapper.Map<Employee>(empDto);
            await _empRepository.AddEmployeeAsync(employee);
        }




        public async Task UpdateEmployeeAsync(int id, EmployeeDto empDto)
        {
            var employee = _mapper.Map<Employee>(empDto);
            await _empRepository.UpdateEmployeeAsync(id,employee);
        }




        public async Task DeleteEmployeeAsync(int id)
        {
            await _empRepository.DeleteEmployeeAsync(id);
        }



    }
}
