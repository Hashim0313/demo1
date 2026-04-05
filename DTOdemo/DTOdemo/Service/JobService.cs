using AutoMapper;
using DTOdemo.DTO;
using DTOdemo.Models;
using Microsoft.EntityFrameworkCore;




namespace DTOdemo.Service
{
    public class JobService
    {

        private readonly DTODemoDbContext _context;

        private readonly IMapper _mapper;


        public JobService (DTODemoDbContext context , IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task <List <JobDto> > GetAllJobsAsync()
        {
            var jobs = await _context.Jobs.ToListAsync();
            return _mapper.Map<List<JobDto>>(jobs);
        }

        public async Task AddJobAsync(JobDto jobdto)
        {

            var job = _mapper.Map<Job>(jobdto);
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();

        }


    }
}
