using AutoMapper;
using RazorExercise.Dto;
using RazorExercise.Models;

namespace RazorExercise.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, RegisterDto>().ReverseMap();

            CreateMap<User, LoginDto>().ReverseMap();
        }

    }
}
