namespace SPN.Services.Contracts.Forum
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using SPN.Data.Models.Forum;
    using SPN.Web.InputModels.ForumInputModels.Category;
    using SPN.Web.ViewModels.ForumViewModels.CategoryViewModels;

    public interface ICategoryService
    {
        Task<CategoryListingViewModel> GetAllCategoriesAsync();

        Task CreateCategoryAsync(CategoryInputModel categoryInputModel);

        Task DeleteCategoryAsync(int categoryId);

        Task UpdateCategoryTitleAsync(int categoryId, string newTitle);

        Task UpdateCategoryDescriptionAsync(int categoryId, string newDescription);

        Task<Category> GetCategoryByIdAsync(int categoryId);

        Task<CategoryTopicModel> GetCategoryTopic(int categoryId);
    }
}
