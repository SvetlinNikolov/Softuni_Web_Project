﻿namespace SPN.Web.Controllers.ForumControllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using System.Net;
    using System.Threading.Tasks;
    using SPN.Forum.Services.Contracts;
    using SPN.Forum.Web.InputModels.Reply;
    using SPN.Services.Shared;

    public class ReplyController : BaseController
    {
        private readonly IPostService postService;
        private readonly IReplyService replyService;

        public ReplyController(
            IUserService userService,
            IMapper mapper,
            IPostService postService,
            IReplyService replyService)
            : base(userService, mapper)
        {
            this.postService = postService;
            this.replyService = replyService;
        }

        public IActionResult Create()
        {
            return this.View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(ReplyInputModel model)
        {
            if (this.ModelState.IsValid)
            {
                var user = await this.userService.GetLoggedInUserAsync();
                await this.replyService.CreateReplyAsync(model, user);

                return this.Redirect($"/Post/Index?Id={model.Id}");
            }
            else
            {
                return this.View(model);
            }

        }
    }
}