using kilit_data.Context;
using kilit_data.Data.Entity;
using kilit_data.Repository.Interface;
using kilit_data.UnitOfWork.Interface;
using kilit_services.Services.Interfaces;

namespace kilit_services.Services
{
    public class UserService:IUserService
    {
        private readonly IGenericRepository<User> _userRepository;
        private readonly IUnitOfWork<KilitContext> _unitOfWork;
        public UserService(IUnitOfWork<KilitContext> unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _userRepository = _unitOfWork.Repository<User>();
        }

        public IEnumerable<User> Get() { 
            return _userRepository.Get();
        }
        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }
        public void Add(User user)
        {
            _userRepository.Add(user);
        }
        public void Remove(int id)
        {
            User user = _userRepository.GetById(id);
            _userRepository.Remove(user);
        }
    }
}
