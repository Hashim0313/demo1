using AutoMapper;
using BlazorExercise.Dto;
using BlazorExercise.Models;

namespace BlazorExercise.Helper
{
    public class AutoMapperProfile : Profile
    {

        public  AutoMapperProfile()
        {
            CreateMap<Job , JobDto >().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }

    }
}
