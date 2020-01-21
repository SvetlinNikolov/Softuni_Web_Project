namespace Svetlinable.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    using Svetlinable.Data;
    using Svetlinable.Models.Forum;
    using Svetlinable.Models.Shared;
    using Svetlinable.Services.Contracts;
  

    public class CategoryService : ICategoryService
    {
        private readonly SvetlinableDbContext dbContext;

        public CategoryService(SvetlinableDbContext dbContext)
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
            return this.dbContext
                .Categories
                .Include(c => c.Posts); //TODO SEE IF WE NEED TO INCLUDE POSTS REPLIES
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int id)
        {
            throw new NotImplementedException();
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
