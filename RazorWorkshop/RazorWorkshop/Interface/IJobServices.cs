using RazorWorkshop.Dto;
using RazorWorkshop.Model;



namespace RazorWorkshop.Interface
{
    public interface IJobServices
    {

        public Task<List<JobDto>> GetAllJobsAsync();

        public Task<JobDto> GetJobByIdAsync(int id);


        public Task AddJobAsync(JobDto jobDto);


        public Task UpdateJobAsync(int id, JobDto jobDto);

        public Task DeleteJobAsync(int id);

    }
}
