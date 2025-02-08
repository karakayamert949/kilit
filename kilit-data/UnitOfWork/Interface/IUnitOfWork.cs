using kilit_data.Data.Entity;
using kilit_data.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace kilit_data.UnitOfWork.Interface
{
    public interface IUnitOfWork<TContext>:IDisposable where TContext : DbContext
    {
        IGenericRepository<User> Users { get; }
        IGenericRepository<T> Repository<T>() where T : class;
        void SaveChanges();
    }
}
