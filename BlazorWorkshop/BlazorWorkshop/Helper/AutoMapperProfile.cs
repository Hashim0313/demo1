using AutoMapper;
using BlazorWorkshop.Models;
using BlazorWorkshop.Dto;

namespace BlazorWorkshop.Helper
{
    public class AutoMapperProfile :Profile
    {

        public AutoMapperProfile()
        {

            CreateMap<JobProvider, JobProviderDto>().ReverseMap();
            CreateMap<Job, JobDto>().ReverseMap();

        }

    }
}
