using AutoMapper;
using SPN.Data;
using SPN.Web.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Services.Shared
{
    public class UserProfileService : BaseService, IUserProfileService
    {
        private readonly IUserService userService;

        public UserProfileService(IMapper mapper, SPNDbContext dbContext, IUserService userService)
            : base(mapper, dbContext)
        {
            this.userService = userService;
        }

        public async Task<UserProfileViewModel> UserProfileDetails()
        {
            var user = await this.userService.GetLoggedInUserAsync();

            var profile = new UserProfileViewModel  //TODO MAP THIS
            {
                Id = user.Id,
                Username = user.UserName,
                Email = user.Email,
                ProfileImage = user.ProfileImage,
                MemberSince = user.CreatedOn,

            };

            return profile;
        }
    }
}
