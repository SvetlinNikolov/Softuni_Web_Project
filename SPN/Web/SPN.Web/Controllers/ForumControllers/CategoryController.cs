namespace Svetlinable.Web.Controllers.ForumControllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using System.Linq;
    using SPN.Services.Contracts.Forum;
    using SPN.Web.ViewModels.ForumViewModels.CategoryViewModels;
    using SPN.Web.ViewModels.ForumViewModels.PostViewModels;
    using SPN.Data.Models.Forum;

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
            var allCategories = categoryService
                .GetAllCategories()
                .Select(c => new CategoryConciseViewModel
                {
                    Id = c.Id,
                    Title = c.Title,
                    Description = c.Description
                });

            var categoryListing = new CategoryWrapperViewModel
            {
                CategoryListing = allCategories
            };

            return View(categoryListing);
        }

        public IActionResult Info(int id)
        {
            var category = categoryService.GetCategoryById(id);
            var posts = postService.GetPostsByCategory(id);

            var categoryListings = posts.Select(p => new PostListingViewModel
            {

                Id = p.Id,
                AuthorId = p.Author.Id,
                Title = p.Title,
                CreatedOn = p.CreatedOn.ToString(),
                RepliesCount = p.Replies.Count,   //TODO Maybe implement service here
                Category = BuildCategoryListing(p)
            });

            return View();
        }

        private CategoryConciseViewModel BuildCategoryListing(Post post)
        {
            var category = post.Category;

            var model = new CategoryConciseViewModel
            {
                Id = category.Id,
                Title = category.Title,
                Description = category.Description,
                ImageUrl = category.ImageUrl
            };

            return model;
        }

    }
}
