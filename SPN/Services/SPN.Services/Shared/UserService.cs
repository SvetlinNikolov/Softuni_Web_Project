namespace SPN.Services.Shared
{

    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using SPN.Data;
    using SPN.Data.Models.Identity;
    using System.Security.Claims;
    using System.Threading.Tasks;
    public class UserService : IUserService
        {
            private readonly SPNDbContext context;
            private readonly IHttpContextAccessor httpContextAccessor;

            public UserService(SPNDbContext context, IHttpContextAccessor httpContextAccessor)
            {
                this.context = context;
                this.httpContextAccessor = httpContextAccessor;
            }
            public async Task<User> GetLoggedInUserAsync()
            {
                var userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

                var user = await context.Users
                    .SingleOrDefaultAsync(u => u.Id == userId);

                return user;
            }

     
    }
}
