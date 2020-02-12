namespace SPN.Services.QuizServices
{
    using AutoMapper;
    using SPN.Data;
    using SPN.Data.Models.Quiz;
    using SPN.Services.Contracts.Quiz;
    using SPN.Services.Shared;
    using SPN.Web.InputModels.QuizInputModels;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class ContestCategoryService : BaseService, IContestCategoryService
    {
        public ContestCategoryService(IMapper mapper, SPNDbContext dbContext)
            : base(mapper, dbContext)
        {
        }

        public Task CreateCategoryAsync(ContestCategoryInputModel contestCategoryInputModel)
        {
            ContestCategory contestCategory = new ContestCategory
            {

            };
           return null;
        }

        public Task DeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ContestCategory>> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ContestCategory> GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
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
