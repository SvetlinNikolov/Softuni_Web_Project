namespace SPN.Web.Controllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;

    using SPN.Services.Shared;
    public abstract class BaseController : Controller
    {

        protected readonly IUserService userService;
        protected readonly IMapper mapper;

        public BaseController(IUserService userService, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }

    }
}
