

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SPN.Services.Contracts.Forum;
using SPN.Services.Shared;

namespace SPN.Web.Controllers.ForumControllers
{
    public class ReplyController:Controller
    {
        private readonly IPostService postService;
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public ReplyController(IPostService postService, IUserService userService,IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
            this.postService = postService;
        }



    }
}
