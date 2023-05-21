using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EntryApp.Models
{
    /// <summary>
    /// EntryApp related dependancy injection configuration
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    public static class EntryAppExtensions
    {

        public static void AddDependencyInjectionContainerForEntryApp(this IServiceCollection services, IConfiguration configuration)
        {
            // EntryAppDbContext.cs Inject: New DbContext Add
            services.AddDbContext<EntryAppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);

            // IEntryRepository.cs Inject: add Service(Repository) DI Container
            services.AddTransient<IEntryRepository, EntryRepository>();
        }
    }
}
