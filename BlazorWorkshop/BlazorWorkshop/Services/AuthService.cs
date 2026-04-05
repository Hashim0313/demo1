using BlazorWorkshop.Interface;
using BlazorWorkshop.Models;
using BlazorWorkshop.Dto;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using AutoMapper;




namespace BlazorWorkshop.Services
{
    public class AuthService : IAuthService
    {

        private readonly IJobProviderRepository _jobProviderRepo;

        private readonly ProtectedSessionStorage _sessionStorage;

        private readonly IMapper _mapper;



        public AuthService (IJobProviderRepository jobProviderRepo , ProtectedSessionStorage sessionStorage , IMapper mapper)
        {

            _jobProviderRepo = jobProviderRepo;

            _sessionStorage = sessionStorage;

            _mapper = mapper;

        }



        public async Task<bool>Register(JobProviderDto jobProviderDto)
        {
            var existingProvider = await _jobProviderRepo.GetByEmailAsync(jobProviderDto.Email);

            if (existingProvider != null)
                return false;


            var jobProvider = _mapper.Map<JobProvider>(jobProviderDto);

            jobProvider.PasswordHash = BCrypt.Net.BCrypt.HashPassword(jobProviderDto.Password);

            await _jobProviderRepo.AddAsync(jobProvider);
            return true;

        }


        public async Task<bool> Login(string email , string password)
        {

            var jobProvider = await _jobProviderRepo.GetByEmailAsync(email);

            if (jobProvider == null || !BCrypt.Net.BCrypt.Verify(password, jobProvider.PasswordHash))
            {
                return false;
            }



            
            

                await _sessionStorage.SetAsync("JobProviderId", jobProvider.ID);

                await _sessionStorage.SetAsync("JobProviderEmail", jobProvider.Email);

                //Console.WriteLine("Session stored successfully");


            

            return true;

            


        }


        public async Task Logout()
        {
            await _sessionStorage.DeleteAsync("JobProivder");
            await _sessionStorage.DeleteAsync("JobProviderEmail");
        }




    }
}
