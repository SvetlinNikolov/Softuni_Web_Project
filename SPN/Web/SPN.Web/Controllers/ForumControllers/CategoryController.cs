namespace Svetlinable.Web.Controllers.ForumControllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using SPN.Data.Models.Forum;
    using SPN.Services.Contracts.Forum;
    using SPN.Web.InputModels.ForumInputModels.Category;
    using SPN.Web.ViewModels.ForumViewModels.CategoryViewModels;
    using SPN.Web.ViewModels.ForumViewModels.Post;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;

    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IPostService postService;
        private readonly IMapper mapper;

        public CategoryController(ICategoryService categoryService, IPostService postService, IMapper mapper)
        {
            this.categoryService = categoryService;
            this.postService = postService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await this.categoryService.
                GetAllCategoriesAsync();

           var categoryModel = this.mapper
                .Map<IEnumerable<CategoryConciseViewModel>>(categories); //Map

            var model = new CategoryListingViewModel
            {
                CategoryListing = categoryModel
            };

            return this.View(model);
        }


        public IActionResult Create()
        {
            return this.View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(CategoryInputModel model)
        {
            if (ModelState.IsValid)
            {

                var result = await this.categoryService.CreateCategoryAsync(model);

                return this.Redirect("/");
            }
            else
            {
                var result = this.View("Error", this.ModelState);
                result.StatusCode = (int)HttpStatusCode.BadRequest;

                return result;
            }
        }

        public async Task<IActionResult> Topic(int id)
        {
            var category = await categoryService.GetCategoryByIdAsync(id);
            var posts = await postService.GetPostsByCategoryAsync(id);

            var categoryConcise = this.mapper
                .Map<CategoryConciseViewModel>(category);

            var postListing = this.mapper
                .Map<IEnumerable<PostListingViewModel>>(posts); 

            var model = new CategoryTopicModel
            {
                Category = categoryConcise,
                Posts = postListing
            };

            return this.View(model);
        }

    }
}
