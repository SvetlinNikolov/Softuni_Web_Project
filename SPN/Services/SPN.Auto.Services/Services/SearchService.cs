using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Auto.Web.ViewModels.Automobile;
using SPN.Auto.Web.ViewModels.Search;
using SPN.Data.Models.Auto;
using SPN.Forum.Data;
using SPN.Services.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Services
{
    public class SearchService : BaseService, ISearchService
    {
        public SearchService(IMapper mapper, SPNDbContext dbContext)
            : base(mapper, dbContext)
        {
        }

        public async Task<AutomobileViewModel> GetAutomobileViewModelByIdAsync(int id)
        {
            var automobile = await this.dbContext
                .Automobiles
                .Where(x => x.Id == id)
               .FirstOrDefaultAsync();

            AutomobileViewModel viewModel = this.mapper.Map<AutomobileViewModel>(automobile);

            return viewModel;
        }

        public async Task<SearchResultListingViewModel> GetSearchResultsAsync(MainSearchInputModel inputModel)
        {
            throw new NotImplementedException();
        }


    }
}
