using RazorWorkshop.Helper;
using RazorWorkshop.Interface;
using RazorWorkshop.Model;
using RazorWorkshop.Repository;
using RazorWorkshop.Service;
using Microsoft.EntityFrameworkCore;



namespace RazorWorkshop.Extension
{
    public static class ApplicationServiceExtension
    {

        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<JobDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnectionString")));


            services.AddScoped<IJobRepository, JobRepository>();

            services.AddScoped<IJobServices, JobService>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IAuthServices, AuthService>();
            services.AddAutoMapper(typeof(AutoMapperProfile));

            services.AddSession();

            return services;

        }

    }
}
