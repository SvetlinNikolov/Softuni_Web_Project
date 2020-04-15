namespace SPN.Services.Shared
{
    using SPN.Data.Models.Shared.Identity;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    

    public interface IUserService
    {
        Task<User> GetLoggedInUserAsync();

        Task<User> GetUserByIdAsync(string id);

        Task<bool> AddUserToRoleAsync(string userId, string role);

        Task<bool> RemoveUserFromToRoleAsync(string userId, string role);

        Task<IEnumerable<User>> GetUsersByRoleAsync(string role);

        string GetLoggedInUserId();
    }
}
