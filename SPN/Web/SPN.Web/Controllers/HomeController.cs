using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Auto.Web.ViewModels.Index;
using SPN.Services.Shared;
using SPN.Web.Controllers;
using System.Threading.Tasks;

public class HomeController : BaseController
{
    private readonly IMakeService makeService;
    private readonly IModelService modelService;
    private readonly IAutoService autoService;
    private readonly ISearchService searchService;

    public HomeController(IUserService userService,
        IMapper mapper,
        IMakeService makeService,
        IModelService modelService,
        IAutoService autoService,
        ISearchService searchService)
        : base(userService, mapper)
    {
        this.makeService = makeService;
        this.modelService = modelService;
        this.autoService = autoService;
        this.searchService = searchService;
    }

    public async Task<IActionResult> Index(IndexViewModel model)
    {
        if (!this.searchService.SearchModelIsNull(model))
        {
            this.RedirectToAction("Results", "Search", model.SearchConcise);
        }
        model.NewestAdverts = await this.searchService.GetNewestAdvertsConciseAsync();
        return this.View(model);
    }


    public IActionResult Api()
    {

        return this.View();
    }
}

