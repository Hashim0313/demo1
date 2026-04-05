using BlazorWorkshop.Dto;

namespace BlazorWorkshop.Interface
{
    public interface IJobService
    {
        Task<List<JobDto>> GetJobsByProviderIdAsync(int ProviderId);


        Task<bool> AddJobAsync(JobDto jobDto, int providerId);


        Task<bool> UpdateJobAsync(JobDto jobDto);


        Task<bool> DeleteJobAsync(int jobId);



    }
}
