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

        public SearchController(IUserService userService, IMapper mapper, ISearchService searchService)
            : base(userService, mapper)
        {
            this.searchService = searchService;
        }

        [HttpGet]
        public async Task<IActionResult> Results(MainSearchInputModel model)
        {
            SearchResultListingViewModel viewModel = await this.searchService.GetSearchResultsAsync(model);

            return this.View(model);
        }

        [HttpGet]
        public IActionResult Index(MainSearchInputModel model)
        {
            if (model.PrimaryProperties != null || model.Safety != null || model.InteriorMaterials != null || model.Interiors != null || model.SpecializedFeatures != null || model.Suspensions != null)
            {
                return this.RedirectToAction("Results", model);
            }

            //TODO Implement this.
            return this.View(model);
        }
    }
}
