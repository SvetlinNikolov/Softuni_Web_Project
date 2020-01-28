namespace Svetlinable.Web.Controllers.ForumControllers
{
    using Microsoft.AspNetCore.Mvc;
    using SPN.Services.Contracts.Forum;

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
                .GetAllCategories();

            //var categoryListing = new CategoryListingViewModel
            //{
            //    CategoryListing = allCategories
            //};

            //return View(categoryListing);
        }

        public IActionResult Subject(int id)
        {
            var category = categoryService.GetCategoryById(id);
            var posts = postService.GetPostsByCategory(id);
            return this.View();
            //var postListings = posts.Select(post => new PostListingViewModel
            //{

            //    Id = post.Id,
            //    AuthorId = post.AuthorId,
            //     Title = post.Title,
            //    CreatedOn = post.CreatedOn.ToString(),
            //    RepliesCount = post.Replies.Count,   //TODO Maybe implement service here
            //    Category = BuildCategoryListing(post)
            //});

            //var model = new CategorySubjectModel
            //{
            //    Posts = postListings,
            //    Category = BuildCategoryListing(category)
            //};

            //return View(model);
        }

        //private CategoryConciseViewModel BuildCategoryListing(Post post) //This shouldnt stay like this
        //{
        //    var category = post.Category;

        //    return BuildCategoryListing(category);
        //}

        //private CategoryConciseViewModel BuildCategoryListing(Category category)
        //{
        //    return new CategoryConciseViewModel
        //    {
        //        Id = category.Id,
        //        Title = category.Title,
        //        Description = category.Description,
        //        ImageUrl = category.ImageUrl
        //    };
        //}

    }
}
