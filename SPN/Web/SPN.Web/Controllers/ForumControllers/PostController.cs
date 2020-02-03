namespace SPN.Web.Controllers.ForumControllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using SPN.Services.Contracts.Forum;
    using SPN.Services.Shared;
    using SPN.Web.InputModels.ForumInputModels.Post;
    using SPN.Web.ViewModels.ForumViewModels.Post;
    using System.Net;
    using System.Threading.Tasks;

    public class PostController : Controller
    {
        private readonly IPostService postService;
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public PostController(IPostService postService, IUserService userService, IMapper mapper)
        {
            this.postService = postService;
            this.userService = userService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index(int id)
        {
            var model = await this.postService.GetPostIndexViewModelAsync(id);

            return this.View(model);
        }

        public IActionResult Create()
        {
            return this.View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(PostInputModel model)
        {
            if (this.ModelState.IsValid)
            {
                var user = await this.userService.GetUserAsync();
                await this.postService.CreatePostAsync(model, user); //This was model.Id

                return this.Redirect($"/Category/Topic?Id={model.Id}");
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

