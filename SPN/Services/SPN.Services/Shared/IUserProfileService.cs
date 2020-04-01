using SPN.Forum.Web.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Forum.Services.Shared
{
    public interface IUserProfileService
    {
        Task<UserProfileViewModel> UserProfileDetails();

    }
}
