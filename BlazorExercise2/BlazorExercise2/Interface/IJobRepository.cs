using BlazorExercise2.Models;

namespace BlazorExercise2.Interface
{
    public interface IJobRepository
    {
        Task<List<Job1>> GetAllJobsAsync();

        Task AddJobAsync(Job1 job);
    }
}
