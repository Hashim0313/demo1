using AutoMapper;
using RazorExercise.Dto;
using RazorExercise.Interface;
using RazorExercise.Models;



namespace RazorExercise.Service
{
    public class AuthService  :IAuthService
    {
        private readonly IAuthRepository AuthRepository;

        private readonly IMapper _mapper;


        public AuthService (IAuthRepository _authRepository , IMapper mapper)
        {
            
            AuthRepository = _authRepository;
            _mapper = mapper;

        }


        public async Task Register(RegisterDto RDto)
        {

            var reg = _mapper.Map<User>(RDto);

            AuthRepository.Register(reg);

        }



        public async Task <RegisterDto> Login(LoginDto LDto)
        {

            var user = _mapper.Map<User>(LDto);

            var loggedUser = await AuthRepository.Login(user);

            return _mapper.Map<RegisterDto>(loggedUser);

        }



    }
}
