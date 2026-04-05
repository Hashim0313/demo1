using Microsoft.EntityFrameworkCore;
using razorassessment.Helper;
using razorassessment.Models;

namespace razorassessment.Extension
{
    public static class AppServiceExtensions
    {

        public static IServiceCollection AddAppServices(this IServiceCollection services , IConfiguration Config)
        {

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Config.GetConnectionString("DefaultConnectionString")));

            services.AddAutoMapper(typeof(AutoMapperProfile));


            return services;

        }

    }
}
