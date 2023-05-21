
using EntryApp.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

namespace EntryApp.Apis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // EntryApp 관련 의존성(종속성) 주입 관련 코드만 따로 모아서 관리 
            var configuration = builder.Configuration; // Retrieve the configuration object
            AddDependencyInjectionContainerForEntryApp(builder.Services, configuration);
            //builder.Services.AddDependencyInjectionContainerForEntryApp(Configuration);

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

        /// <summary>
        /// EntryApp related dependancy injection configuration
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        private static void AddDependencyInjectionContainerForEntryApp(IServiceCollection services, IConfiguration configuration)
        {
            // EntryAppDbContext.cs Inject: New DbContext Add
            services.AddDbContext<EntryAppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // IEntryRepository.cs Inject: add Service(Repository) DI Container
            services.AddTransient<IEntryRepository, EntryRepository>();
        }
    }
}