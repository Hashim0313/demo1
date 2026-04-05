using AutoMapper;
using DTOdemo.DTO;
using DTOdemo.Models;

namespace DTOdemo.Helper
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile ()
        {
            CreateMap<Job, JobDto>().ReverseMap();
        }

    }
}
