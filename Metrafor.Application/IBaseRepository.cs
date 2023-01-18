namespace Metrafor.Application
{
    public interface IBaseRepository<T>
    {
        Task<T?> FindAsync(Guid id);
        Task SaveAsync(T entity);
    }
}
