namespace Svetlinable.Web.Controllers.ForumControllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using System.Linq;
    using Svetlinable.Services.Contracts.Forum;
    using Svetlinable.Web.ViewModels.ForumViewModels.CategoryViewModels;

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
                .Select(c => new CategoryListingViewModel
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

            var categoryListings = posts.Select(p => new CategoryListingViewModel
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Content,
          
            });
            return View();
        }
    }
}
