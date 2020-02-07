namespace SPN.Web.Controllers.ForumControllers
{
    using AutoMapper;
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    using SPN.Services.Contracts.Forum;
    using SPN.Services.Shared;
    using SPN.Web.InputModels.ForumInputModels.Post;
  
    public class PostController : BaseController
    {
        private readonly IPostService postService;

        public PostController(
            IUserService userService,
            IMapper mapper,
            IPostService postService)
            : base(userService, mapper)
        {
            this.postService = postService;
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
                var user = await this.userService.GetLoggedInUserAsync();
                await this.postService.CreatePostAsync(model, user); 

                return this.Redirect($"/Category/Topic?Id={model.CategoryId}");
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

