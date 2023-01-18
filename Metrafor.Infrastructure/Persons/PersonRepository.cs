using Metrafor.Application;
using Metrafor.Domain.Entries;
using Microsoft.EntityFrameworkCore;

namespace Metrafor.Infrastructure.Persons
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PersonsDbContext Context = null!;

        protected DbSet<Person> Aggregates => Context.Aggregates;

        public PersonRepository(PersonsDbContext context)
        {
            Context = context;
        }

        public Task<Person?> FindAsync(Guid id)
            => Aggregates
                .Where(a => a.PersonId == id)
                .FirstOrDefaultAsync();

        public async Task SaveAsync(Person entity)
        {
            if (Context.Entry(entity).State == EntityState.Detached)
            {
                await Context.Aggregates.AddAsync(entity);
            }

            await Context.SaveChangesAsync();
        }
    }
}
