namespace Svetlinable.Web.Controllers.ForumControllers
{
    using Microsoft.AspNetCore.Mvc;
    using SPN.Services.Contracts.Forum;
    using SPN.Web.ViewModels.ForumViewModels.CategoryViewModels;
    using SPN.Web.ViewModels.ForumViewModels.Post;
    using System;
    using System.Linq;

    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IPostService postService;
        public CategoryController(ICategoryService categoryService, IPostService postService)
        {
            this.categoryService = categoryService;
            this.postService = postService;

        }

        public IActionResult Index()
        {
            var categories = this.categoryService.
                GetAllCategories()
                 .Select(c => new CategoryConciseViewModel
                 {
                     Id = c.Id,
                     Title = c.Title,
                     Description = c.Description,
                     ImageUrl = c.ImageUrl
                 });

            var model = new CategoryListingViewModel
            {
                CategoryListing = categories
            };

            return this.View(model);
        }

        public IActionResult Topic(int id)
        {
            var category = categoryService.GetCategoryByIdWithPosts(id);
            var posts = postService.GetPostsByCategory(id);
            

            var categoryConcise = new CategoryConciseViewModel
            {
                Id = category.Id,
                Description = category.Description,
                Title = category.Title,
                ImageUrl = category.ImageUrl
            };
            var postListing = category.Posts.Select(p => new PostListingViewModel
            {
                Id = p.Id,
                CategoryName = p.Category.Title,
                AuthorId = p.Author.Id,
                AuthorName = p.Author.UserName,
                CreatedOn = p.CreatedOn.ToString(),
                Title = p.Title
            });



            var model = new CategoryTopicModel
            {
                Category = categoryConcise,
                Posts = postListing
            };

            return this.View(model);
        }

    }
}
