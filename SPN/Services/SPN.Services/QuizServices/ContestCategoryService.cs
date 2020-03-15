namespace SPN.Services.QuizServices
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using SPN.Data;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Quiz;
    using SPN.Services.Contracts.Quiz;
    using SPN.Services.Shared;
    using SPN.Web.InputModels.QuizInputModels.ContestCategory;
    using SPN.Web.ViewModels.QuizViewModels.ContestCategory;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class ContestCategoryService : BaseService, IContestCategoryService
    {
        public ContestCategoryService(IMapper mapper, SPNDbContext dbContext)
            : base(mapper, dbContext)
        {
        }

        public async Task CreateCategoryAsync(ContestCategoryInputModel contestCategoryInputModel)
        {
            var category = this.mapper.Map<ContestCategoryInputModel, ContestCategory>(contestCategoryInputModel);

            await this.dbContext.ContestCategories.AddAsync(category);
            await this.dbContext.SaveChangesAsync();
        }

        public Task DeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }



        public async Task<ContestCategoryListingViewModel> GetAllCategoriesAsync()
        {
          var categories = await this.dbContext
                 .ContestCategories
                 .Include(cc => cc.Contests)
                 .ToListAsync();

            var categoriesConcise = this.mapper.Map<IEnumerable<ContestCategoryConciseViewModel>>(categories);

            var model = new ContestCategoryListingViewModel
            {
                CategoryListing = categoriesConcise
            };

            return model;
        }

        public async Task<ContestCategory> GetCategoryByIdAsync(int id)
        {
            var category = await this.dbContext
                .ContestCategories
                .Where(cc => cc.Id == id)
                .Include(cc => cc.Contests)
                .SingleOrDefaultAsync();

            return category;
        }

        public Task UpdateCategoryDescriptionAsync(int categoryId, string newDescription)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryTitleAsync(int categoryId, string newTitle)
        {
            throw new NotImplementedException();
        }


    }
}
