using Metrafor.Domain.Entries;
using Metrafor.Migrations.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Metrafor.Migrations
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Person> Persons => Set<Person>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=postgres81.1gb.ru;Port=5432;Database=xgb_metrafor;User ID=xgb_metrafor;Password=XypmW3N3Wt-B;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
        }
    }
}
