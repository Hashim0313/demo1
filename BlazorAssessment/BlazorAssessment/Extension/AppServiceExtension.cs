using BlazorAssessment.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAssessment.Extension
{
    public static class AppServiceExtension
    {
        public static IServiceCollection AddAppService
            (this  IServiceCollection service, IConfiguration config)
        {

            service.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnectionString")));

            return service;

        }
    }
}
