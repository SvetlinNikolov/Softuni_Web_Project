using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.ViewModels.Home;
using SPN.Auto.Web.ViewModels.Index;
using SPN.Services.Shared;
using SPN.Web.Controllers;
using System.Threading.Tasks;

public class HomeController : BaseController
{
    private readonly IMakeService makeService;
    private readonly IModelService modelService;

    public HomeController(IUserService userService,
        IMapper mapper,
        IMakeService makeService,
        IModelService modelService)
        : base(userService, mapper)
    {
        this.makeService = makeService;
        this.modelService = modelService;
    }

    public async Task<IActionResult> Index()
    {
        var makes = await this.makeService.GetAllMakes();
        var models = this.modelService.GetAllModels();

        IndexPageViewModel viewModel = new IndexPageViewModel
        {
          
        };

        return this.ValidationProblem();
    }
    public IActionResult Api()
    {

        return this.View();
    }
}
