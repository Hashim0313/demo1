using RazorWorkshop.Model;
using RazorWorkshop.Interface;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using RazorWorkshop.Dto;
using RazorWorkshop.Repository;



namespace RazorWorkshop.Repository
{
    public class AuthService : IAuthServices
    {

        private readonly IAuthRepository AuthRepository;

        private readonly IMapper _mapper;


        public AuthService (IAuthRepository _authRepository , IMapper mapper)
        {
            AuthRepository = _authRepository;
            _mapper = mapper;
        }


        public async Task Register(UserRegisterDto registerDto)
        {

            var reg = _mapper.Map<User>(registerDto);

             AuthRepository.Register(reg);

        }


        public async Task<UserRegisterDto> Login(UserLoginDto loginDto)
        {
            var user = _mapper.Map<User>(loginDto);
            var loggedUser=await AuthRepository.Login(user);
            return _mapper.Map<UserRegisterDto>(loggedUser);

            //var user=await AuthRepository.Login(loginDto);
            //if (user)
            //    return true;
            //return false;

        }


    }
}
