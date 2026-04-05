using BlazorExercise.Interface;
using BlazorExercise.Models;
using BlazorExercise.Dto;
using Microsoft.EntityFrameworkCore;


namespace BlazorExercise.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly BlazorExerciseContext _context;

        public JobRepository(BlazorExerciseContext context)
        {
            _context = context;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

    }
}
