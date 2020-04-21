using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Auto.Web.ViewModels.Search;
using SPN.Services.Shared;

namespace SPN.Web.Controllers
{
    public class SearchController : BaseController
    {
        private readonly ISearchService searchService;
        private const int ItemsPerPage = 10;

        public SearchController(IUserService userService, IMapper mapper, ISearchService searchService)
            : base(userService, mapper)
        {
            this.searchService = searchService;
        }

        public IActionResult Listing(SearchResultListingViewModel viewModel)
        {
            return this.View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Results(MainSearchInputModel model, int page = 1)
        {
            var query = HttpContext.Request.QueryString.ToString();

            this.ViewData["query"] = Uri.EscapeUriString(query);

            SearchResultListingViewModel viewModel = await this.searchService.GetSearchResultsAsync(model, ItemsPerPage, (page - 1) * ItemsPerPage);

            if (viewModel == null)
            {
                return this.View(viewModel);
            }
            int countOfAutomobiles = viewModel == null ? 0 : viewModel.SearchResults.Count();

            if (viewModel?.PagesCount == null)
            {
                viewModel.PagesCount = (int)Math.Ceiling((double)countOfAutomobiles / ItemsPerPage);
            }

            if (viewModel.PagesCount == 0)
            {
                viewModel.PagesCount = 1;
            }

            viewModel.CurrentPage = page;

            return this.View(viewModel);

        }


        [HttpGet]
        public IActionResult Index(MainSearchInputModel model)

        {
            if (!this.searchService.SearchModelIsNull(model))
            {
                return this.RedirectToAction("Results", model);
            }

            return this.View(model);

        }
    }
}
