namespace SPN.Services.Contracts.Quiz
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Quiz;
    using SPN.Web.InputModels.QuizInputModels;
    using SPN.Web.ViewModels.QuizViewModels.ContestCategory;

    public interface IContestCategoryService
    {
        Task<ContestCategoryListingViewModel> GetAllCategoriesAsync();

        Task CreateCategoryAsync(ContestCategoryInputModel contestCategoryInputModel);

        Task DeleteCategoryAsync(int categoryId);

        Task UpdateCategoryTitleAsync(int categoryId, string newTitle);

        Task UpdateCategoryDescriptionAsync(int categoryId, string newDescription);

        Task<ContestCategory> GetCategoryByIdAsync(int id);

    }
}
