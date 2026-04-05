using BlazorExercise2.Helper;
using BlazorExercise2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorExercise2.Extension
{
    public static class AppExtensionService
    {
        public static IServiceCollection AddAppServiceExtension(this IServiceCollection services , IConfiguration config)
        {

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnectionString")));

            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;
        }
    }
}
