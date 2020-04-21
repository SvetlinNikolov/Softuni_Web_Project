using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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

        public AutomobileController(IUserService userService, IMapper mapper, ISearchService searchService, IAutoService autoService)
            : base(userService, mapper)
        {
            this.searchService = searchService;
            this.autoService = autoService;
        }

        public async Task<IActionResult> Index(int id)
        {
            AutomobileViewModel model = await this.autoService.GetAutomobileViewModelByIdAsync(id);

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MainCreateInputModel inputModel)
        {
            await this.autoService.CreateAutomobileAsync(inputModel);

            return this.View(inputModel);
        }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var viewModel = await this.autoService.GetAutomobileEditInputModelAsync(id);
            return this.View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditAutomobileInputModel inputModel)
        {
            await this.autoService.EditAutomobileAsync(id, inputModel);

            return this.Redirect($"/Automobile/Index/{id}");
        }
    }
}
