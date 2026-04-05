using BlazorExercise.Dto;

namespace BlazorExercise.Interface
{
    public interface IJobService
    {
        Task<List<JobDto>> GetAllJobsAsync();

    }
}
