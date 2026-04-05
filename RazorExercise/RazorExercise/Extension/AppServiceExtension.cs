using RazorExercise.Helper;
using RazorExercise.Interface;
using RazorExercise.Repository;
using RazorExercise.Service;

namespace RazorExercise.Extension
{
    public static class AppServiceExtension
    {


        public static IServiceCollection AddAppServices(this IServiceCollection services , IConfiguration Config)
        {
            services.AddAutoMapper(typeof(AutoMapperProfile));


            services.AddScoped<IAuthRepository, AuthRepository>();

            services.AddScoped<IAuthService, AuthService>();

            services.AddAutoMapper(typeof(AutoMapperProfile));


            services.AddSession();


            return services;

        }


    }
}
