using BlazorWorkshop.Models;

namespace BlazorWorkshop.Interface
{
    public interface IJobProviderRepository
    {

        Task<JobProvider> GetByEmailAsync(string Email);

        Task AddAsync(JobProvider jobProvider);

    }
}
