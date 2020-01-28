namespace SPN.Services.Contracts.Forum
{
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using System.Collections.Generic;
 
    using System.Threading.Tasks;

    public interface ICategoryService
    {
        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategories();
        Task CreateCategory(Category category);
        Task DeleteCategory(int categoryId);
        Task UpdateCategoryTitle(int categoryId, string newTitle);
        Task UpdateCategoryDescription(int categoryId, string newDescription);

    }
}
