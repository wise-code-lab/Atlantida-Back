using Atlantida.Models;
using Atlantida.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Atlantida.Extensions
{
    public static class WebHostExtensions
    {
        public static IWebHost SeedData(this IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var roleManager = services.GetService<RoleManager<ApplicationRole>>();

                new RoleSeeder(roleManager).SeedData().GetAwaiter().GetResult();
            }
            return host;
        }
    }
}
