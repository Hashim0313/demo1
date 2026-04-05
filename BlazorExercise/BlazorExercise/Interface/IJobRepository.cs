using BlazorExercise.Models;
using BlazorExercise.Dto;


namespace BlazorExercise.Interface
{
    public interface IJobRepository
    {
        Task<List<Job>> GetAllJobsAsync();
    }
}
