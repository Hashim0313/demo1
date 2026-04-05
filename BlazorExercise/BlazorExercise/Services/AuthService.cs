using BlazorExercise.Interface;
using BlazorExercise.Models;
using BlazorExercise.Dto;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using AutoMapper;

namespace BlazorExercise.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepo;

        private readonly ProtectedSessionStorage _sessionStorage;

        private readonly IMapper _mapper;

        public AuthService (IUserRepository userRepo , ProtectedSessionStorage sessionStorage , IMapper mapper)
        {
            _userRepo = userRepo;
            _sessionStorage = sessionStorage;
            _mapper = mapper;
        }


        public async Task <bool> Register(UserDto userDto)
        {
            var existingUser = await _userRepo.GetByEmailAsync(userDto.Email);
            if (existingUser != null)
                return false;

            var useruser = _mapper.Map<User>(userDto);
            useruser.Password = BCrypt.Net.BCrypt.HashPassword(userDto.Password);

            await _userRepo.AddAsync(useruser);
            return true;
        }

        public async Task<bool> Login(string email , string password)
        {
            var useruser = await _userRepo.GetByEmailAsync(email);
            if(useruser == null || !BCrypt.Net.BCrypt.Verify(password, useruser.Password))
            {
                return false;
            }

            await _sessionStorage.SetAsync("UserId", useruser.Id);
            await _sessionStorage.SetAsync("UserEmail", useruser.Email);

            return true;
        }

    }
}
