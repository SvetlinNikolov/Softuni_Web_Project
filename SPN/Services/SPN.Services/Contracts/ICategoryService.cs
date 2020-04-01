namespace SPN.Forum.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using SPN.Forum.Data.Models;
    using SPN.Forum.Web.InputModels.Category;
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
