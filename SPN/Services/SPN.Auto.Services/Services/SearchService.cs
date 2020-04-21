using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SPN.Auto.Services.Contracts;
using SPN.Auto.Services.Services.Helpers;
using SPN.Auto.Web.InputModels.Automobile;
using SPN.Auto.Web.ViewModels.Search;
using SPN.Forum.Data;
using SPN.Services.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPN.Auto.Services.Services
{
    public class SearchService : BaseService, ISearchService
    {
        private const int ItemsPerPage = 10;

        private readonly IMakeService makeService;
        private readonly ValidatePrimaryPropertiesSearch primaryPropertiesValidator;
        private readonly ValidateInteriorSearch interiorsValidator;
        private readonly ValidateInteriorMaterialsSearch interiorMaterialsvalidator;
        private readonly ValidateSafetySearch safetyValidator;
        private readonly ValidateSpecializedFeaturesSearch specializedFeaturesValidator;
        private readonly ValidateSuspensionsSearch suspensionsValidator;
        private readonly ValidateExtraFeaturesSearch extraFeaturesValidator;

        public SearchService(IMapper mapper,
            SPNDbContext dbContext,
            IMakeService makeService,
            ValidatePrimaryPropertiesSearch primaryPropertiesValidator,
            ValidateInteriorSearch interiorsValidator,
            ValidateInteriorMaterialsSearch interiorMaterialsvalidator,
            ValidateSafetySearch safetyValidator,
            ValidateSpecializedFeaturesSearch specializedFeaturesValidator,
            ValidateSuspensionsSearch suspensionsValidator,
            ValidateExtraFeaturesSearch extraFeaturesValidator)
            :

            base(mapper, dbContext)
        {
            this.makeService = makeService;
            this.primaryPropertiesValidator = primaryPropertiesValidator;
            this.interiorsValidator = interiorsValidator;
            this.interiorMaterialsvalidator = interiorMaterialsvalidator;
            this.safetyValidator = safetyValidator;
            this.specializedFeaturesValidator = specializedFeaturesValidator;
            this.suspensionsValidator = suspensionsValidator;
            this.extraFeaturesValidator = extraFeaturesValidator;
        }

        public int GetAutomobilesCount()
        {
            return this.dbContext.Automobiles.Count();
        }


        public async Task<SearchResultListingViewModel> GetNewestAdvertsAsync(int? take = null, int skip = 0)
        {
            var results = await this.dbContext.Automobiles

                .OrderByDescending(x => x.CreatedOn)
                .Where(x => x.IsDeleted == false)
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

        public async Task<IEnumerable<SearchResultConciseViewModel>> GetNewestAdvertsConciseAsync(int? take = null)
        {
            var results = await this.dbContext.Automobiles
                .Where(x => x.IsDeleted == false)
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
            .Where(x => x.IsDeleted == false)
            .Include(x => x.Make)
            .Include(x => x.Model)
            .Include(x => x.User)
            .AsNoTracking();

            automobiles = primaryPropertiesValidator.ValidateSearchProperties(inputModel, automobiles);
            automobiles = interiorsValidator.ValidateSearchProperties(inputModel, automobiles);
            automobiles = interiorMaterialsvalidator.ValidateSearchProperties(inputModel, automobiles);
            automobiles = safetyValidator.ValidateSearchProperties(inputModel, automobiles);
            automobiles = specializedFeaturesValidator.ValidateSearchProperties(inputModel, automobiles);
            automobiles = suspensionsValidator.ValidateSearchProperties(inputModel, automobiles);
            automobiles = extraFeaturesValidator.ValidateSearchProperties(inputModel, automobiles);

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
