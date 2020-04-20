using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SPN.Services.Shared;
using System.Threading.Tasks;

namespace SPN.Web.Controllers
{
    public class UserController : BaseController
    {

        public UserController(IUserService userService, IMapper mapper) 
            : base(userService, mapper)
        {
   
        }

        public async Task<IActionResult> Details(string id)
        {
            var viewModel = await this.userService.GetUserViewModelByUserIdAsync(id);

            return this.View(viewModel);
        }
    }
}
