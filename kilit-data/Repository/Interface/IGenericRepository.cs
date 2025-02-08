namespace kilit_data.Repository.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> Get();
        T GetById(int id);
        void Add(T entity);
        void Remove(T entity);
    }
}
