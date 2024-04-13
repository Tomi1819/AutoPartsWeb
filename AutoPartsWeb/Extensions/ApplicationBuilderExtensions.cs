namespace AutoPartsWeb.Extensions
{
    using AutoPartsWeb.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using static AutoPartsWeb.Core.Constants.IdentityRole;

    public static class ApplicationBuilderExtensions
    {
        public static async Task CreateAdminRoleAsync(this IApplicationBuilder application)
        {
            using var scope = application.ApplicationServices.CreateScope();

            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (userManager != null && roleManager != null && await roleManager.RoleExistsAsync(AdminRole) == false)
            {
                var role = new IdentityRole(AdminRole);
                await roleManager.CreateAsync(role);

                var admin = await userManager.FindByIdAsync("dea12856-c198-4129-b3f3-b893d8395082");

                if (admin != null)
                {
                    await userManager.AddToRoleAsync(admin, role.Name);
                }
            }
        }

        public static async Task CreateDealerRoleAsync(this IApplicationBuilder application)
        {
            using var scope = application.ApplicationServices.CreateScope();

            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (userManager != null && roleManager != null && await roleManager.RoleExistsAsync(DealerRole) == false)
            {
                var role = new IdentityRole(DealerRole);
                await roleManager.CreateAsync(role);

                var dealer = await userManager.FindByIdAsync("1a558517-6bd0-4da4-9a6c-e5d92df0a945");

                if (dealer != null)
                {
                    await userManager.AddToRoleAsync(dealer, role.Name);
                }
            }
        }
    }
}
