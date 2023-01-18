using Metrafor.Domain.Entries;
using Metrafor.Infrastructure.Users.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Metrafor.Infrastructure.Users
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options) { }

        internal DbSet<User> Aggregates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
