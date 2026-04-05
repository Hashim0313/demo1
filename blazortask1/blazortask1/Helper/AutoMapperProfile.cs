using AutoMapper;
using blazortask1.Dto;
using blazortask1.Model;

namespace blazortask1.Helper
{
    public class AutoMapperProfile :Profile
    {
        
        public AutoMapperProfile ()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
        }

    }
}
