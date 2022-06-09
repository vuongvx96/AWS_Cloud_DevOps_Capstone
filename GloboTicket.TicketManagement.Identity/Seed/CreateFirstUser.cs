using System.Threading.Tasks;
using GloboTicket.TicketManagement.Identity.Models;
using Microsoft.AspNetCore.Identity;

namespace GloboTicket.TicketManagement.Identity.Seed
{
    public static class UserCreator
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var applicationUser = new ApplicationUser
            {
                FirstName = "Vuong",
                LastName = "Vo",
                UserName = "vuongvx",
                Email = "vuongvx@test.com",
                EmailConfirmed = true
            };

            var user = await userManager.FindByEmailAsync(applicationUser.Email);
            if (user == null)
            {
                await userManager.CreateAsync(applicationUser, "Plural&01?");
            }
        }
    }
}