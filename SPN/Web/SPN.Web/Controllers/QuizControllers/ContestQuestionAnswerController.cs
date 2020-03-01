using AutoMapper;
using SPN.Services.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPN.Web.Controllers.QuizControllers
{
    public class ContestQuestionAnswerController : BaseController
    {
        public ContestQuestionAnswerController(IUserService userService, IMapper mapper) : base(userService, mapper)
        {
        }
    }
}
