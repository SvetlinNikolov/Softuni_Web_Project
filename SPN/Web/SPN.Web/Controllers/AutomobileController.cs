using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Auto.Web.ViewModels.Automobile;
using SPN.Services.Shared;

namespace SPN.Web.Controllers
{
    public class AutomobileController : BaseController
    {
        private readonly ISearchService searchService;
        private readonly IAutoService autoService;

        public AutomobileController(IUserService userService, IMapper mapper, ISearchService searchService,IAutoService autoService)
            : base(userService, mapper)
        {
            this.searchService = searchService;
            this.autoService = autoService;
        }

        public async Task<IActionResult> Index(int id)
        {
            AutomobileViewModel model = await this.searchService.GetAutomobileViewModelByIdAsync(id);

            return this.View(model);
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
    }
}
