using BlazorWorkshop.Models;
using BlazorWorkshop.Helper;
using BlazorWorkshop.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using BlazorWorkshop.Repository;
using BlazorWorkshop.Services;


namespace BlazorWorkshop.Extension
{
    public static class ApplicationServiceExtension
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {




            services.AddDbContext<JobProviderDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnectionString")));




            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });




            services.AddAutoMapper(typeof(AutoMapperProfile));


            services.AddScoped<IJobProviderRepository, JobProviderRepository>();

            services.AddScoped<IJobRepository, JobRepository>();

            services.AddScoped<IJobService, JobService>();

            services.AddScoped<IAuthService, AuthService>();

            
            services.AddScoped<ProtectedSessionStorage>();



            return services;
        }

    }
}
