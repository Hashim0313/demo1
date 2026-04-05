using BlazorWorkshop.Interface;
using BlazorWorkshop.Models;
using Microsoft.EntityFrameworkCore;





namespace BlazorWorkshop.Repository
{
    public class JobProviderRepository : IJobProviderRepository
    {

        private readonly JobProviderDbContext _context;



        public JobProviderRepository(JobProviderDbContext context)
        {
            _context = context;
        }




        public async Task <JobProvider> GetByEmailAsync(string email)
        {
            return await _context.JobProviders.FirstOrDefaultAsync(jp => jp.Email == email);
        }



        public async Task AddAsync (JobProvider jobProvider)
        {
            _context.JobProviders.Add(jobProvider);
            await _context.SaveChangesAsync();
        }

    }
}
