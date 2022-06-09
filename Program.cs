using BaseAPI.Core.Security.Hashing;
using BaseAPI.Persistence;
using BaseAPI.Persistence.Contexts;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BaseAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            using (var scope = host.Services.CreateScope())
            using (var context = scope.ServiceProvider.GetService<AppDbContext>())
            {
                //services, paswordhasher ,databaseSeedSonradan eklendi sorun çýkarsa silerek denenecek
                var services = scope.ServiceProvider;
                context.Database.EnsureCreated();
                //
                var passwordHasher = services.GetService<IPasswordHasher>();
                //
                DatabaseSeed.Seed(context, passwordHasher);
            }

            host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();
    }
}
