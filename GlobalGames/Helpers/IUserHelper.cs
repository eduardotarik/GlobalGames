using GlobalGames.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace GlobalGames.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);
    }
}
