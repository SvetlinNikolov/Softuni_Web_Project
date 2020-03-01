using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SPN.Services.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPN.Web.Controllers.QuizControllers
{
    public class ContestController : BaseController
    {
        public ContestController(IUserService userService, IMapper mapper) 
            : base(userService, mapper)
        {
        }

        
    }
}
