using Metrafor.Domain.Entries;

namespace Metrafor.Application
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User?> FindByLoginAsync(string login);
    }
}
