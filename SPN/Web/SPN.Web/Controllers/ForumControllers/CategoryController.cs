namespace Svetlinable.Web.Controllers.ForumControllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;
    
    using SPN.Services.Contracts.Forum;
    using SPN.Services.Shared;
    using SPN.Web.Controllers;
    using SPN.Web.InputModels.ForumInputModels.Category;
    using SPN.Web.ViewModels.ForumViewModels.CategoryViewModels;
    using SPN.Web.ViewModels.ForumViewModels.Post;
    [Authorize(Roles ="Admin")]
    public class CategoryController : BaseController
    {
        private readonly IPostService postService;
        private readonly ICategoryService categoryService;

        public CategoryController(
            IUserService userService,
            IMapper mapper,
            IPostService postService,
            ICategoryService categoryService
            )
            : base(userService, mapper)
        {
            this.postService = postService;
            this.categoryService = categoryService;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model = await this.categoryService.
                GetAllCategoriesAsync();

            return this.View(model);
        }

    
        public IActionResult Create()
        {
            return this.View();
        }

      
        [HttpPost]
        public async Task<IActionResult> Create(CategoryInputModel model)
        {
            if (ModelState.IsValid)
            {
                await this.categoryService.CreateCategoryAsync(model);

                return this.Redirect($"/Category/Topic/{model.Id}");
            }
            else
            {
                return this.View(model);
            }
        }

        [AllowAnonymous]
        public async Task<IActionResult> Topic(int id)
        {
            var model = await this.categoryService.GetCategoryTopic(id);

            return this.View(model);
        }

    }
}
