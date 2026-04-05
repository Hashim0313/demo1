using RazorWorkshop.Model;
using RazorWorkshop.Interface;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using RazorWorkshop.Dto;



namespace RazorWorkshop.Repository
{
    public class AuthRepository : IAuthRepository 
    {
        private readonly JobDbContext _context;



        public AuthRepository (JobDbContext context)
        {
            _context = context;
        }



        public async Task Register (User user)
        {

             _context.UsersInfo.Add(user);
            _context.SaveChanges();

           
        }



        public async Task<User> Login(User Dto)
        {

            var logUser=_context.UsersInfo.SingleOrDefault(u => u.Email == Dto.Email && u.Password == Dto.Password);
            if (logUser == null)
            {
                return null;
            }
            return logUser;

        }

    }
}
