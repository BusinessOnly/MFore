using Metrafor.Application;
using Metrafor.Domain.Entries;
using Microsoft.EntityFrameworkCore;

namespace Metrafor.Infrastructure.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly UsersDbContext Context = null!;

        protected DbSet<User> Aggregates => Context.Aggregates;

        public UserRepository(UsersDbContext context)
        {
            Context = context;
        }

        public Task<User?> FindAsync(Guid id)
            => Aggregates
                .Where(a => a.UserId == id)
                .FirstOrDefaultAsync();

        public Task<User?> FindByLoginAsync(string login)
            => Aggregates
                .Where(a => a.Login == login)
                .FirstOrDefaultAsync();

        public async Task SaveAsync(User entity)
        {
            if (Context.Entry(entity).State == EntityState.Detached)
            {
                await Context.Aggregates.AddAsync(entity);
            }

            await Context.SaveChangesAsync();
        }
    }
}
