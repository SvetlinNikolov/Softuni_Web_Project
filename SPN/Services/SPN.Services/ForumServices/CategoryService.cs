namespace SPN.Services.ForumServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;

    using SPN.Data;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Services.Contracts.Forum;
    using SPN.Services.Shared;
    using SPN.Web.ViewModels.ForumInputModels.Contracts;

    public class CategoryService : ICategoryService
    {
        private readonly SPNDbContext dbContext;

        public CategoryService(SPNDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<int> CreateCategory(ICategoryInputModel inputModel)
        {
            var category = new Category
            {
                Description = inputModel.Description,
                Title = inputModel.Title,
                ImageUrl = inputModel.ImageUrl,

            };

            category.CreatedOn = DateTime.UtcNow;
            await this.dbContext.Categories.AddAsync(category);
            return await this.dbContext.SaveChangesAsync();
        }

        public Task DeleteCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return dbContext
                .Categories
                .Include(c => c.Posts)
                .ToList(); //TODO SEE IF WE NEED TO INCLUDE POSTS REPLIES
        }

        public Category GetCategoryById(int id)
        {

            var category =
               dbContext
               .Categories
               .Where(c => c.Id == id)
               .Include(x => x.Posts)
               .FirstOrDefault();

            return category;
        }

        public async Task UpdateCategoryDescription(int categoryId, string newDescription)
        {
            var categoryToUpdate = this.GetCategoryById(categoryId);
            categoryToUpdate.Description = newDescription;

            this.dbContext.Update(categoryToUpdate);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task UpdateCategoryTitle(int categoryId, string newTitle)
        {
            var category = this.GetCategoryById(categoryId);
            category.Title = newTitle;

            this.dbContext.Update(category);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
