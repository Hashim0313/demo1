using BlazorExercise.Interface;
using BlazorExercise.Models;
using BlazorExercise.Dto;
using BlazorExercise.Repository;
using BlazorExercise.Services;
using BlazorExercise.Helper;


namespace BlazorExercise.Extension
{
    public static class ApplicationServiceExtension
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services , IConfiguration config)
        {
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddAutoMapper(typeof(AutoMapperProfile));

            services.AddScoped<IAuthService, AuthService>();

            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IJobRepository, JobRepository>();

            services.AddScoped<IJobService, JobService>();

            return services;

        }


    }
}
