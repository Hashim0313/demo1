using BlazorExercise.Interface;
using BlazorExercise.Models;
using BlazorExercise.Dto;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using AutoMapper;
using BlazorExercise.Repository;


namespace BlazorExercise.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;

        public JobService(IJobRepository jobRepository , IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public async Task <List<JobDto>>GetAllJobsAsync()
        {
            var jobs = await _jobRepository.GetAllJobsAsync();
            return _mapper.Map<List<JobDto>>(jobs);
        }

    }
}
