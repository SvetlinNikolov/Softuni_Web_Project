namespace SPN.Web.Controllers.ForumControllers
{
    using Microsoft.AspNetCore.Mvc;
    using SPN.Services.Contracts.Forum;

    public class PostController : Controller
    {
        private readonly IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService;
        }

        public IActionResult Index(int id)
        {
            var post = this.postService.GetPostById(id);

            return this.View();
        }
    }
}
