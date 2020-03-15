using SPN.Web.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Services.Common
{
    public interface IUserProfileService
    {
        Task<UserProfileViewModel> UserProfileDetails();

    }
}
