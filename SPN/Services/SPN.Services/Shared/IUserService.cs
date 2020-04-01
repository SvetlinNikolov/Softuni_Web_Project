namespace SPN.Forum.Services.Shared
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using SPN.Forum.Data.Models.Identity;

    public interface IUserService
    {
        Task<User> GetLoggedInUserAsync();

        Task<User> GetUserByIdAsync(string id);

        Task<bool> AddUserToRoleAsync(string userId, string role);

        Task<bool> RemoveUserFromToRoleAsync(string userId, string role);

        Task<IEnumerable<User>> GetUsersByRoleAsync(string role);
    }
}
