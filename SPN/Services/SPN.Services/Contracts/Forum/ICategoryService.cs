namespace SPN.Services.Contracts.Forum
{
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Web.ViewModels.ForumInputModels.Contracts;
    using System.Collections.Generic;
 
    using System.Threading.Tasks;

    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
        Task<int> CreateCategory(ICategoryInputModel categoryInputModel);
        Task DeleteCategory(int categoryId);
        Task UpdateCategoryTitle(int categoryId, string newTitle);
        Task UpdateCategoryDescription(int categoryId, string newDescription);
        Category GetCategoryById(int id);
    }
}
