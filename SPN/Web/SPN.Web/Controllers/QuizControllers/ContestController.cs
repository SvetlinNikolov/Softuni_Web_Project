using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SPN.Services.Contracts.Quiz;
using SPN.Services.Shared;
using SPN.Web.InputModels.QuizInputModels.Contest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPN.Web.Controllers.QuizControllers
{
    public class ContestController : BaseController
    {
        private readonly IContestService contestService;

        public ContestController(IUserService userService, IMapper mapper, IContestService contestService)
            : base(userService, mapper)
        {
            this.contestService = contestService;
        }
        public IActionResult Index(int id) //TODO service  create viewModel
        {

            return this.View();
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContestCreateInputModel inputModel)
        {
            if (this.ModelState.IsValid)
            {
                await this.contestService.CreateContestAsync(inputModel);
                return this.Redirect("");
            }

            return this.View(inputModel);
        }
    }
}

