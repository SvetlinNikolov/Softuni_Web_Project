using AutoMapper;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Services.Services.Helpers;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Auto.Web.ViewModels.Automobile;
using SPN.Auto.Web.ViewModels.Search;
using SPN.Data.Common.Constants;
using SPN.Data.Models.Auto;
using SPN.Forum.Data;
using SPN.Services.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Services
{
    public class SearchService : BaseService, ISearchService
    {
        private const int ItemsPerPage = 10;
        private readonly IMakeService makeService;

        public SearchService(IMapper mapper, SPNDbContext dbContext, IMakeService makeService)
            : base(mapper, dbContext)
        {
            this.makeService = makeService;


        }

        public int GetAutomobilesCount()
        {
            return this.dbContext.Automobiles.Count();
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
               .FirstOrDefaultAsync();

            AutomobileViewModel viewModel = this.mapper.Map<AutomobileViewModel>(automobile);

            return viewModel;
        }

        public async Task<SearchResultListingViewModel> GetNewestAdvertsAsync(int? take = null, int skip = 0)
        {
            var results = await this.dbContext.Automobiles
                .AsNoTracking()
                .OrderByDescending(x => x.CreatedOn)
                .Take(take ?? ItemsPerPage)
                .Include(x => x.Make)
                .Include(x => x.Model)
                .Include(x => x.PrimaryProperties)
                .Include(x => x.Images)
              .Select(x => new SearchResultConciseViewModel
              {
                  Id = x.Id,
                  Make = x.Make.Name,
                  Model = x.Model.Name,
                  Title = x.Title,
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
                SearchResults = results,
            };

            return viewModel;
        }

        public async Task<IEnumerable<SearchResultConciseViewModel>> GetNewestAdvertsConciseAsync(int? take=null)
        {
            var results = await this.dbContext.Automobiles
                .AsNoTracking()
                .OrderByDescending(x => x.CreatedOn)
                .Take(take ?? ItemsPerPage)
                .Include(x => x.Make)
                .Include(x => x.Model)
                .Include(x => x.PrimaryProperties)
                .Include(x => x.Images)
              .Select(x => new SearchResultConciseViewModel
              {
                  Id = x.Id,
                  Make = x.Make.Name,
                  Model = x.Model.Name,
                  Title = x.Title,
                  SellerId = x.UserId,
                  Mileage = x.PrimaryProperties.Mileage,
                  CreatedOn = x.CreatedOn,
                  Year = x.PrimaryProperties.Year,
                  Price = x.PrimaryProperties.Price,
                  ImageUrl = x.Images.ImageUrl1
              })
              .ToListAsync();

            return results;
        }

        public async Task<SearchResultListingViewModel> GetSearchResultsAsync(MainSearchInputModel inputModel, int? take = null, int skip = 0)
        {
            if (this.SearchModelIsNull(inputModel.PrimaryProperties))
            {
                return null;
            }
            if (this.SearchModelIsNull(inputModel))
            {
                return null;
            }
            var automobiles = this.dbContext
            .Automobiles
            .Include(x => x.Make)
            .Include(x => x.Model)
            .Include(x => x.User)
            .AsNoTracking();

            var PrimaryPropertiesValidator = new ValidatePrimaryPropertiesSearch();
            var InteriorsValidator = new ValidateInteriorSearch();
            var InteriorMaterialsvalidator = new ValidateInteriorMaterialsSearch();
            var SafetyValidator = new ValidateSafetySearch();
            var SpecializedFeaturesValidator = new ValidateSpecializedFeaturesSearch();
            var SuspensionsValidator = new ValidateSuspensionsSearch();
            var ExtraFeaturesValidator = new ValidateExtraFeaturesSearch();


            automobiles = PrimaryPropertiesValidator.ValidateSearchProperties(inputModel, automobiles);
            automobiles = InteriorsValidator.ValidateSearchProperties(inputModel, automobiles);
            automobiles = InteriorMaterialsvalidator.ValidateSearchProperties(inputModel, automobiles);
            automobiles = SafetyValidator.ValidateSearchProperties(inputModel, automobiles);
            automobiles = SpecializedFeaturesValidator.ValidateSearchProperties(inputModel, automobiles);
            automobiles = SuspensionsValidator.ValidateSearchProperties(inputModel, automobiles);
            automobiles = ExtraFeaturesValidator.ValidateSearchProperties(inputModel, automobiles);

            if (take.HasValue)
            {
                automobiles = automobiles
                    .OrderByDescending(x => x.CreatedOn)
                    .Skip(skip)
                    .Take(take.Value);
            }
            else
            {
                automobiles = automobiles
                    .OrderByDescending(x => x.CreatedOn)
                 .Skip(skip);
            }

            var searchResults = await automobiles
                .Select(x => new SearchResultConciseViewModel
                {
                    Id = x.Id,
                    Make = x.Make.Name,
                    Model = x.Model.Name,
                    SellerId = x.UserId,
                    SellerName = x.User.UserName,
                    Title = x.Title,
                    Mileage = x.PrimaryProperties.Mileage,
                    CreatedOn = x.CreatedOn,
                    Year = x.PrimaryProperties.Year,
                    Price = x.PrimaryProperties.Price,
                    ImageUrl = x.Images.ImageUrl1
                })
            .ToListAsync();

            var viewModel = new SearchResultListingViewModel { SearchResults = searchResults };

            return viewModel;
        }


        public bool SearchModelIsNull(object model)
        {
            if (model == null)
            {
                return true;
            }

            bool isNull = model.GetType().GetProperties().All(x => x.GetValue(model) == null);

            return isNull;
        }

    }
}
