using BlazorExercise.Interface;
using BlazorExercise.Models;
using BlazorExercise.Dto;
using Microsoft.EntityFrameworkCore;

namespace BlazorExercise.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly BlazorExerciseContext _context;

        public UserRepository(BlazorExerciseContext context)
        {
            _context = context;
        }

        public async Task <User> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(uu => uu.Email == email);
        }


        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }


    }
}
