using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Services.Shared;

namespace SPN.Web.Controllers
{
    public class SearchController : BaseController
    {
        private readonly ISearchService searchService;

        public SearchController(IUserService userService, IMapper mapper,ISearchService searchService) 
            : base(userService, mapper)
        {
            this.searchService = searchService;
        }

        public IActionResult SearchById(MainSearchInputModel model)
        {
            throw new NotImplementedException();
        }
    }
}
