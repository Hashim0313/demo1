using AutoMapper;
using BlazorExercise2.Dto;
using BlazorExercise2.Models;

namespace BlazorExercise2.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job1, Job1Dto>().ReverseMap();
        }
    }
}
