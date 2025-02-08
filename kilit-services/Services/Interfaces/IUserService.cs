using kilit_data.Data.Entity;

namespace kilit_services.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> Get();
        User GetById(int id);
        void Add(User user);
        void Remove(int id);

    }
}
