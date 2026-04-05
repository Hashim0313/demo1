using AutoMapper;
using RazorWorkshop.Dto;
using RazorWorkshop.Model;



namespace RazorWorkshop.Helper



{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Job, JobDto>().ReverseMap();

            CreateMap<User, UserRegisterDto>().ReverseMap();

            CreateMap<User, UserLoginDto>().ReverseMap();

        }
    }
}
