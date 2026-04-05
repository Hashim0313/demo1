using Microsoft.EntityFrameworkCore;
using razorassessment.Models;
using razorassessment.Dto;
using AutoMapper;


namespace razorassessment.Helper
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Book, BookDto>().ReverseMap();
        }

    }
}
