using Metrafor.Application;
using Metrafor.Infrastructure.Persons;
using Metrafor.Infrastructure.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Metrafor.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static void AddContext(this IServiceCollection services, string postgresConnectionString)
        {
            services.AddDbContextPool<UsersDbContext>(options => options.UseNpgsql(postgresConnectionString));
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddDbContextPool<PersonsDbContext>(options => options.UseNpgsql(postgresConnectionString));
            services.AddScoped<IPersonRepository, PersonRepository>();
        }
    }
}
