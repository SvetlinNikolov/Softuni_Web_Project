using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPN.Services.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPN.Web.Controllers.QuizControllers
{
    public class ContestQuestionController : BaseController
    {
        public ContestQuestionController(IUserService userService, IMapper mapper) 
            : base(userService, mapper)
        {
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(IFormCollection formCollection)
        {
            
            return this.View();
        }
    }
}
