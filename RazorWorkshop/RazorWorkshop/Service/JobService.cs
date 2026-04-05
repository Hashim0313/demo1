using RazorWorkshop.Model;
using RazorWorkshop.Interface;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using RazorWorkshop.Dto;



namespace RazorWorkshop.Service
{
    public class JobService : IJobServices
    {

        private readonly IJobRepository jobRepository;
        private readonly IMapper _mapper;

        public JobService (IJobRepository _jobRepository, IMapper mapper)
        {
            jobRepository = _jobRepository;
            _mapper = mapper;
        }



        public async Task<List<JobDto>> GetAllJobsAsync()
        {
            var job = await jobRepository.GetAllJobsAsync();
            return _mapper.Map<List<JobDto>>(job);
        }


         public async Task<JobDto> GetJobByIdAsync(int id)
        {
           var job=await jobRepository.GetJobByIdAsync(id);
            return _mapper.Map<JobDto>(job);
        }


        public async Task AddJobAsync(JobDto jobDto)
        {
            var job = _mapper.Map<Job>(jobDto);
            await jobRepository.AddJobAsync(job);
        }


        public async Task UpdateJobAsync(int id, JobDto jobDto)
        {
            var job = _mapper.Map<Job>(jobDto);
            await jobRepository.UpdateJobAsync(id, job);
        }

        public async Task DeleteJobAsync(int id)
        {
            await jobRepository.DeleteJobAsync(id);
        }










    }
}
