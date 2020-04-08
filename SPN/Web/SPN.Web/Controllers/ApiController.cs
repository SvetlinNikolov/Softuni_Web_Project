using Microsoft.AspNetCore.Mvc;
using SPN.Auto.Services.Contracts;
using SPN.Forum.Web.InputModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPN.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly IMakeService makeService;

        public ApiController(IMakeService autoService)
        {
            this.makeService = autoService;
        }

        [HttpGet("Index")]
        public async Task<ActionResult<MakesListingViewModel>> Index()
        {
            var makes = await this.makeService.GetAllMakes();

            return makes;
        }
    }
}
