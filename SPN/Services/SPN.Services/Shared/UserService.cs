
using Microsoft.AspNetCore.Identity;
using SPN.Data.Models.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SPN.Services.Shared
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public UserService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public User GetUser(ClaimsPrincipal principal)
        {
            var user = this.userManager.GetUserAsync(principal).GetAwaiter().GetResult();

            return user;
        }
    }
}
