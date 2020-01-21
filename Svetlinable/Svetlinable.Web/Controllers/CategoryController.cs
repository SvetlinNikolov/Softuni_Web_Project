
namespace Svetlinable.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using System.Linq;

    using Svetlinable.Services.Contracts;
    using Svetlinable.Web.ViewModels.CategoryViewModels;

    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var allCategories = this.categoryService
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

            return this.View(categoryListing);
        }
    }
}
