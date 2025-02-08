using kilit_data.Context;
using kilit_data.Data.Entity;
using kilit_data.Repository;
using kilit_data.Repository.Interface;
using kilit_data.UnitOfWork.Interface;
using Microsoft.EntityFrameworkCore;

namespace kilit_data.UnitOfWork
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext
    {
        private readonly TContext _context;
        public IGenericRepository<User> Users { get; }
        public UnitOfWork(TContext context)
        {
            _context = context;
            Users = new GenericRepository<User>(_context);
        }
        public IGenericRepository<T> Repository<T>() where T : class
        {
            return new GenericRepository<T>(_context);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
