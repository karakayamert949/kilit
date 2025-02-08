
using kilit_data.Data.Model;

namespace kilit_services.Services.Interfaces
{
    public interface IAccountService
    {
        bool LoginUser(LoginRequest request);
        bool LogoutUser(int userId);
    }
}
