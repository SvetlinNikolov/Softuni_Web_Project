namespace SPN.Services.Shared
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using SPN.Data.Models.Shared.Identity;
    using SPN.Forum.Data;

    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;


    public class UserService : IUserService
    {
        private readonly SPNDbContext context;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<User> userManager;
        private readonly SPNDbContext dbContext;

        public UserService(SPNDbContext context,
                IHttpContextAccessor httpContextAccessor,
                UserManager<User> userManager,
                SPNDbContext dbContext
                )
        {
            this.context = context;
            this.httpContextAccessor = httpContextAccessor;
            this.userManager = userManager;
            this.dbContext = dbContext;

        }


        public async Task<User> GetLoggedInUserAsync()
        {
            var userId = httpContextAccessor
                .HttpContext
                .User
                .FindFirst(ClaimTypes.NameIdentifier)
                .Value;

            var user = await context.Users
                .SingleOrDefaultAsync(u => u.Id == userId);

            return user;
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            return await dbContext
                .Users
                .FirstOrDefaultAsync(x => x.Id == id);

        }

        public async Task<IEnumerable<User>> GetUsersByRoleAsync(string role)
        {
            var usersInRole = await userManager.GetUsersInRoleAsync(role);

            return await dbContext
                .Users
                .Where(u => usersInRole.Any(x => x.Id == u.Id))
                .ToListAsync();
        }

        public async Task<bool> RemoveUserFromToRoleAsync(string userId, string role)
        {
            var user = await GetUserByIdAsync(userId);
            if (user == null)
            {
                return false;
            }

            await userManager.RemoveFromRoleAsync(user, role);
            return true;
        }

        public async Task<bool> AddUserToRoleAsync(string userId, string role)
        {
            var user = await GetUserByIdAsync(userId);

            if (user == null)
            {
                return false;
            }

            await userManager.AddToRoleAsync(user, role);
            return true;
        }

        public string GetLoggedInUserId()
        {

            var userId = httpContextAccessor
                .HttpContext
                .User
                .FindFirst(ClaimTypes.NameIdentifier)
                .Value;

            return userId;
        }
    }
}
