using blazortask1.Helper;
using blazortask1.Interface;
using blazortask1.Model;
using blazortask1.Repository;
using blazortask1.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace blazortask1.Extension
{
    public static class ApplicationServicesExtension
    {

        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration config)
        {

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnectionString")));


            services.AddScoped<IEmployeeRepository ,EmployeeRepository>();
            services.AddScoped<IEmployeeService ,EmployeeService>();

            services.AddAutoMapper(typeof(AutoMapperProfile));

            return services;

        }

    }
}
