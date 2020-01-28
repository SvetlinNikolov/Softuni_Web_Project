namespace SPN.Web.Controllers.ForumControllers
{
    using Microsoft.AspNetCore.Mvc;
    using SPN.Data.Models.Forum;
    using SPN.Services.Contracts.Forum;
    using SPN.Web.ViewModels.ForumViewModels.PostViewModels;
    using SPN.Web.ViewModels.ForumViewModels.Reply;
    using System.Collections.Generic;
    using System.Linq;

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


        private IEnumerable<PostReplyViewModel> GetPostReplies(Post post)
        {
            return post.Replies.Select(reply => new PostReplyViewModel
            {
                Id = reply.Id,
                AuthorName = reply.Author.UserName,
                AuthorId = reply.Author.Id,
                AuthorImageUrl = reply.Author.ProfileImage,
              LikesCount = reply.ReplyLikes.Count,
                CreatedOn = reply.CreatedOn,
                Content = reply.Content,
           
            });
        }
    }
}
