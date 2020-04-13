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

    public HomeController(IUserService userService,
        IMapper mapper,
        IMakeService makeService,
        IModelService modelService,
        IAutoService autoService)
        : base(userService, mapper)
    {
        this.makeService = makeService;
        this.modelService = modelService;
        this.autoService = autoService;
    }

    public IActionResult Index()
    {
        return this.View();
        //var makes = await this.makeService.GetAllMakes();
        //var models = await this.modelService.GetAllModels();

        //IndexPageViewModel viewModel = new IndexPageViewModel
        //{
        //  MakesListing = makes,
        //  ModelsListing = models
        //};

        //return this.View(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> Create(MainCreateInputModel model)
    {
        await this.autoService.CreateAutomobileAsync(model);

        return this.View(model);
    }

    public IActionResult Create()
    {
        return this.View();
    }

    public IActionResult Api()
    {

        return this.View();
    }
}
