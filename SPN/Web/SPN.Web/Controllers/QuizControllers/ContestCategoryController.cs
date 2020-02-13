namespace SPN.Web.Controllers.QuizControllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using SPN.Services.Contracts.Quiz;
    using SPN.Services.Shared;
    using SPN.Web.ViewModels.QuizViewModels.ContestCategory;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ContestCategoryController : BaseController
    {
        private readonly IContestCategoryService contestCategoryService;

        public ContestCategoryController(
            IUserService userService,
            IMapper mapper,
            IContestCategoryService contestCategoryService)
            : base(userService, mapper)
        {
            this.contestCategoryService = contestCategoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categoriesListing = await this.contestCategoryService.GetAllCategoriesAsync();

            return this.View(categoriesListing);
        }

        public Task<IActionResult> Create()
        {
            throw new System.Exception();
        }

        //[HttpPost]
        //public Task<IActionResult> Create()
        //{
        //    throw new System.Exception();
        //}

    }
}
