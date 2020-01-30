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
    using SPN.Web.ViewModels.ForumInputModels.Category;

    public class CategoryService : ICategoryService
    {
        private readonly SPNDbContext dbContext;
        private readonly IMapper mapper;
        public CategoryService(SPNDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<int> CreateCategory(CategoryInputModel inputModel)
        {
            Category category = this.mapper.Map<Category>(inputModel); //Maping

            category.CreatedOn = DateTime.UtcNow;
            await this.dbContext.Categories.AddAsync(category);
            return await this.dbContext.SaveChangesAsync();
        }

        public Task DeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await dbContext
                .Categories
                .Include(c => c.Posts)
                .ToListAsync(); //TODO SEE IF WE NEED TO INCLUDE POSTS REPLIES
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {

            Category category = await this.dbContext
                    .Categories
                    .Where(c => c.Id == id)
                    .Include(x => x.Posts)
                    .SingleOrDefaultAsync();

            return category;
        }

        public async Task UpdateCategoryDescriptionAsync(int categoryId, string newDescription)
        {
            Category categoryToUpdate = await this.GetCategoryByIdAsync(categoryId);
            categoryToUpdate.Description = newDescription;

            this.dbContext.Update(categoryToUpdate);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task UpdateCategoryTitleAsync(int categoryId, string newTitle)
        {
            Category category = await this.GetCategoryByIdAsync(categoryId);
            category.Title = newTitle;

            this.dbContext.Update(category);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
