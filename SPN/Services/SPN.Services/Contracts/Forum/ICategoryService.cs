namespace SPN.Services.Contracts.Forum
{
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Web.InputModels.ForumInputModels.Category;
    using System.Collections.Generic;
 
    using System.Threading.Tasks;

    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
        Task<int> CreateCategoryAsync(CategoryInputModel categoryInputModel);
        Task DeleteCategoryAsync(int categoryId);
        Task UpdateCategoryTitleAsync(int categoryId, string newTitle);
        Task UpdateCategoryDescriptionAsync(int categoryId, string newDescription);
        Task<Category> GetCategoryByIdAsync(int id);
    }
}
