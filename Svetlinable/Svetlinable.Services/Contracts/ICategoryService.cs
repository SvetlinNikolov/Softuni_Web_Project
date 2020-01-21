namespace Svetlinable.Services.Contracts
{
    using Svetlinable.Models.Forum;
    using Svetlinable.Models.Shared;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface ICategoryService
    {
        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategories();
        IEnumerable<User> GetAllUsers();
        Task CreateCategory(Category category);
        Task DeleteCategory(int categoryId);
        Task UpdateCategoryTitle(int categoryId, string newTitle);
        Task UpdateCategoryDescription(int categoryId, string newDescription);

    }
}
