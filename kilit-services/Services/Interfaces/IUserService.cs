using kilit_data.Data.Entity;
using kilit_data.Data.Model;

namespace kilit_services.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> Get();
        User GetById(int id);
        void Add(SignupRequest request);
        void Remove(int id);

    }
}
