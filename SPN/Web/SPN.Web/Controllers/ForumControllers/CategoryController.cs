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

            var categoryListing = new CategoryListingViewModel
            {
                CategoryListing = allCategories
            };

            return View(categoryListing);
        }

        public IActionResult Subject(int id)
        {
            var category = categoryService.GetCategoryById(id);
            var posts = postService.GetPostsByCategory(id);

            var postListings = posts.Select(post => new PostListingViewModel
            {

                Id = post.Id,
                AuthorId = post.AuthorId,
                 Title = post.Title,
                CreatedOn = post.CreatedOn.ToString(),
                RepliesCount = post.Replies.Count,   //TODO Maybe implement service here
                Category = BuildCategoryListing(post)
            });

            var model = new CategorySubjectModel
            {
                Posts = postListings,
                Category = BuildCategoryListing(category)
            };

            return View(model);
        }

        private CategoryConciseViewModel BuildCategoryListing(Post post) //This shouldnt stay like this
        {
            var category = post.Category;

            return BuildCategoryListing(category);
        }

        private CategoryConciseViewModel BuildCategoryListing(Category category)
        {
            return new CategoryConciseViewModel
            {
                Id = category.Id,
                Title = category.Title,
                Description = category.Description,
                ImageUrl = category.ImageUrl
            };
        }

    }
}
