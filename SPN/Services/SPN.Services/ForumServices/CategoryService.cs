namespace SPN.Services.ForumServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using SPN.Data;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Services.Contracts.Forum;

    public class CategoryService : ICategoryService
    {
        private readonly SPNDbContext dbContext;

        public CategoryService(SPNDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task CreateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return dbContext
                .Categories
                .Include(c => c.Posts); //TODO SEE IF WE NEED TO INCLUDE POSTS REPLIES
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int id)
        {
            var category =
                  dbContext
                  .Categories
                  .Where(c => c.Id == id)
                  .Include(c => c.Posts)
                  .FirstOrDefault();

            return category;
        }

        public Task UpdateCategoryDescription(int categoryId, string newDescription)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryTitle(int categoryId, string newTitle)
        {
            throw new NotImplementedException();
        }
    }
}
