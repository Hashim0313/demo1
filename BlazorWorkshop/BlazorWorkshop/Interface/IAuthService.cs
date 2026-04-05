using BlazorWorkshop.Dto;

namespace BlazorWorkshop.Interface
{
    public interface IAuthService
    {

        Task<bool> Register(JobProviderDto jobProviderDto);

        Task<bool> Login(string email, string password);

        Task Logout();

    }
}
