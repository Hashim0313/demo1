using RazorWorkshop.Model;
using RazorWorkshop.Interface;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using RazorWorkshop.Dto;



namespace RazorWorkshop.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly JobDbContext _context;



        public JobRepository(JobDbContext context)
        {
            _context = context;
        }


        public async Task<List<Job>> GetAllJobsAsync()
        {
            var jobs = await _context.JobsInfo.ToListAsync();
            return jobs;
        }



        public async Task<Job> GetJobByIdAsync(int id)
        {
            var job = await _context.JobsInfo.FindAsync(id);
            return job;
        }



        public async Task AddJobAsync(Job job)
        {

            _context.JobsInfo.Add(job);
            await _context.SaveChangesAsync();
        }



        public async Task UpdateJobAsync(int id , Job job)
        {
            var existingJob = await _context.JobsInfo.FindAsync(id);
            if (existingJob == null) return;

            _context.Entry(existingJob).State = EntityState.Detached;


            var updatedJob = job;
            updatedJob.ID = id;

            _context.JobsInfo.Attach(updatedJob);
            _context.Entry(updatedJob).State = EntityState.Modified;

            await _context.SaveChangesAsync();

        }

        public async Task DeleteJobAsync(int id)
        {
            var job = await _context.JobsInfo.FindAsync(id);
            if (job != null)
            {
                _context.JobsInfo.Remove(job);
                await _context.SaveChangesAsync();
            }

        }


    }
}
