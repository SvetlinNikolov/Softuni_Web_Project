namespace SPN.Web.Controllers.ForumControllers
{
    using Microsoft.AspNetCore.Mvc;
    using SPN.Data.Models.Forum;
    using SPN.Services.Contracts.Forum;
    using SPN.Services.Shared;
    using SPN.Web.ViewModels.ForumInputModels.Category;
    using SPN.Web.ViewModels.ForumInputModels.Post;
    using SPN.Web.ViewModels.ForumViewModels.Reply;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;

    public class PostController : Controller
    {
        private readonly IPostService postService;
        private readonly IUserService userService;

        public PostController(IPostService postService,IUserService userService)
        {
            this.postService = postService;
            this.userService = userService;
        }

        public IActionResult Index(int id)
        {
            var post = this.postService.GetPostById(id);


            //var model = new PostIndexViewModel
            //{
            //    Id = post.Id,
            //    Title = post.Title,
            //    AuthorId = post.Author.Id,
            //    AuthorName = post.Author.UserName,
            //    AuthorImageUrl = post.Author.ProfileImage,
            //    CreatedOn = post.CreatedOn,
            //    Content = post.Content,
            //    LikesCount = post.PostLikes.Count,

            //};

            return this.View();
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
                var user = this.userService.GetUser(this.User);
               await this.postService.CreatePost(model, user, model.Id);

                return this.Redirect($"/Forum/Posts?Id={model.Id}");
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

