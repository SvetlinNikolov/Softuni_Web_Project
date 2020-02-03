namespace SPN.Web.Controllers.ForumControllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using SPN.Services.Contracts.Forum;
    using SPN.Services.Shared;
    using SPN.Web.InputModels.ForumInputModels.Reply;
    using System.Net;
    using System.Threading.Tasks;

    public class ReplyController : Controller
    {
        private readonly IPostService postService;
        private readonly IUserService userService;
        private readonly IMapper mapper;
        private readonly IReplyService replyService;

        public ReplyController(
            IPostService postService,
            IUserService userService,
            IMapper mapper,
            IReplyService replyService
            )
        {
            this.userService = userService;
            this.mapper = mapper;
            this.replyService = replyService;
            this.postService = postService;
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
                var user = await this.userService.GetUserAsync();
                await this.replyService.CreateReplyAsync(model, user); 

                return this.Redirect($"/Post/Index?Id={model.Id}");
            }
            else
            {
                var result = this.View("Error", this.ModelState);
                result.StatusCode = (int)HttpStatusCode.BadRequest;

                return result;
            }

        }
    }
}