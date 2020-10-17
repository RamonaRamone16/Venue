using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Venue.DAL.Entities;

namespace Venue.DAL.Seeds
{
    public class DBInitializer
    {
        public static async Task SeedUsers(UserManager<User> userManager)
        {
            if (await userManager.FindByEmailAsync("user@gmail.com") == null)
            {
                var user = new User
                {
                    UserName = "user@gmail.com",
                    Email = "user@gmail.com"
                };

                IdentityResult result = await userManager.CreateAsync(user, "User-123");
            }
        }
    }
}
