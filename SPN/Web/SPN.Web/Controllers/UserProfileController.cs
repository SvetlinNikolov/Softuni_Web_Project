using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SPN.Forum.Services.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPN.Web.Controllers
{
    [Authorize]
    public class UserProfileController : BaseController
    {
        private readonly IUserProfileService userProfileService;

        public UserProfileController(IUserService userService, IMapper mapper, IUserProfileService userProfileService) 
            : base(userService, mapper)
        {
            this.userProfileService = userProfileService;
        }

        public async Task<IActionResult> Details()
        {
            var profileModel = await this.userProfileService.UserProfileDetails();

            return this.View(profileModel);
        }

    }
}
