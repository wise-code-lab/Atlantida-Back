using System;
using System.Linq;
using System.Threading.Tasks;
using Atlantida.Models;
using Microsoft.AspNetCore.Identity;

namespace Atlantida.Services
{
    public class RoleSeeder
    {
        private readonly RoleManager<ApplicationRole> roleManager;

        public RoleSeeder(RoleManager<ApplicationRole> roleManager)
        {
            this.roleManager = roleManager;
        }
        public async Task SeedData()
        {
            await Task.WhenAll(Role.Roles.Select(EnsureRoleExist));
        }

        private async Task EnsureRoleExist(string roleName)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                ApplicationRole role = new ApplicationRole(roleName);
                await roleManager.CreateAsync(role);
            }
        }
    }
}