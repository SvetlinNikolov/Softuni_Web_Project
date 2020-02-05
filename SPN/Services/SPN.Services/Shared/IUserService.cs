namespace SPN.Services.Shared
{
    using SPN.Data.Models.Identity;
    using System;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;

    public interface IUserService
    {
        Task<User> GetLoggedInUserAsync();
    }
}
