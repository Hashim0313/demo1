using BlazorExercise2.Models;
using BlazorExercise2.Interface;


namespace BlazorExercise2.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly AppDbContext _context;

        public JobRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Job1>>GetAllJobsAsync()
        {
            return await._context.
        }

    }
}
