using BlazorExercise2.Dto;

namespace BlazorExercise2.Interface
{
    public interface IJobService
    {
        Task<List<Job1Dto>> GetAllJobsAsync();

        Task<bool> AddJobAsync(Job1Dto jobDto);
    }
}
