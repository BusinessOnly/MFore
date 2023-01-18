using Metrafor.Domain.Entries;
using Metrafor.Infrastructure.Persons.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Metrafor.Infrastructure.Persons
{
    public class PersonsDbContext : DbContext
    {
        public PersonsDbContext(DbContextOptions<PersonsDbContext> options) : base(options) { }

        internal DbSet<Person> Aggregates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
        }
    }
}
