using _826488CW2.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _826488CW2.Data
{
    public static class DbSeeder
{
        public static void SeedDb(ApplicationDbContext context, UserManager<IdentityUser> userManager, 
                                    UserManager<ApplicationUser> memberManager)
        {
            //TODO: Check if data has already been created
            context.Database.EnsureCreated();

            SeedMember(context, memberManager);
            SeedUsers(context, userManager);
        }
                                                                    //TODO: Look into RoleManager
        private static void SeedUsers(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            IdentityUser customer1 = new IdentityUser
            {
                UserName = "Customer1@email.com",
                Email = "Customer1@email.com",
            };
            userManager.CreateAsync(customer1, "Password123!").Wait();

            IdentityUser customer2 = new IdentityUser
            {
                UserName = "Customer2@email.com",
                Email = "Customer2@email.com",
            };
            userManager.CreateAsync(customer2, "Password123!").Wait();

            IdentityUser customer3 = new IdentityUser
            {
                UserName = "Customer3@email.com",
                Email = "Customer3@email.com",
            };
            userManager.CreateAsync(customer3, "Password123!").Wait();

            IdentityUser customer4 = new IdentityUser
            {
                UserName = "Customer4@email.com",
                Email = "Customer4@email.com",
            };
            userManager.CreateAsync(customer4, "Password123!").Wait();

            IdentityUser customer5 = new IdentityUser
            {
                UserName = "Customer5@email.com",
                Email = "Customer5@email.com",
            };
            userManager.CreateAsync(customer5, "Password123!").Wait();
        }

        private static void SeedMember(ApplicationDbContext context, UserManager<ApplicationUser> memberManager)
        {
            ApplicationUser Member1 = new ApplicationUser
            {
                UserName = "Member1@email.com",
                Email = "Customer5@email.com"
            };
            memberManager.CreateAsync(Member1, "Password123!").Wait();
        }
    }
}
