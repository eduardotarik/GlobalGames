using GlobalGames.Data.Entities;
using GlobalGames.Helpers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace GlobalGames.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(DataContext context,
            IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            var user = await _userHelper.GetUserByEmailAsync("tarik@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Tarik",
                    LastName = "Castro",
                    Email = "tarik@gmail.com",
                    UserName = "tarik@gmail.com",
                    PhoneNumber = "214354645"
                };

                var result = await _userHelper.AddUserAsync(user, "123456");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder!");
                }
            }
        }
    }
}
