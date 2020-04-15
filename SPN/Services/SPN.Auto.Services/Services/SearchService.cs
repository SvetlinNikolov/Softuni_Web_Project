using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Auto.Web.ViewModels.Automobile;
using SPN.Auto.Web.ViewModels.Search;
using SPN.Data.Common.Constants;
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
        private const int ItemsPerPage = 2;

        public SearchService(IMapper mapper, SPNDbContext dbContext)
            : base(mapper, dbContext)
        {
        }

        public async Task<AutomobileViewModel> GetAutomobileViewModelByIdAsync(int id)
        {
            Automobile automobile = await this.dbContext
                .Automobiles
                .Where(x => x.Id == id) 
                .Include(x => x.User)
                .Include(x => x.Make)
                .Include(x => x.Model)
                .Include(x => x.PrimaryProperties)
                .Include(x => x.Safety)
                .Include(x => x.Interiors)
                .Include(x => x.InteriorMaterials)
                .Include(x => x.Suspensions)
                .Include(x => x.SpecializedFeatures)
                .Include(x => x.ExtraFeatures)
                .Include(x => x.Make)
                .Include(x => x.Model)
               .FirstOrDefaultAsync();

            AutomobileViewModel viewModel = this.mapper.Map<AutomobileViewModel>(automobile);

            return viewModel;
        }

        public async Task<SearchResultListingViewModel> GetSearchResultsAsync(MainSearchInputModel inputModel, int? take = null, int skip = 0)
        {
            //Idea for search - Make sb, check with reflection every class in inputmodel for props that are not null, if a prop is not null 
            //append it to sb and then use it in .where
            var make = inputModel.PrimaryProperties.Make;
            var model = inputModel.PrimaryProperties.Model;
            //var title = string.Format(ModelConstants.SearchTitle, make, model);

            var results = await this.dbContext.Automobiles.Where(x => x.Make.Name == make && x.Model.Name == model) //TODO Switch to searhing with id
                .Select(x => new SearchResultConciseViewModel
                {
                    Id = x.Id,
                    Make = make,
                    Model = model,
                    //Title = x.Title,
                    SellerId = x.UserId,
                    Mileage = x.PrimaryProperties.Mileage,
                    CreatedOn = x.CreatedOn,
                    Year = x.PrimaryProperties.Year,
                    Price = x.PrimaryProperties.Price,
                    ImageUrl = x.Images.ImageUrl1
                })
                .ToListAsync();

            var viewModel = new SearchResultListingViewModel
            {
                //Title = title,
                SearchResults = results,
            };

            return viewModel;
        }
    }
}
