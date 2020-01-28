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

    public class CategoryService : ICategoryService
    {
        private readonly SPNDbContext dbContext;
        private readonly IMapper mapper;

        public CategoryService(SPNDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public  Task CreateCategory(Category category/*,User user*/)
        {
            //var category =
            //     this.mapper
            //     .Map<CategoryInputModel, Models.Category>(model as CategoryInputModel);

            //category.CreatedOn = DateTime.UtcNow;
            //category.User = user;
            //category.UserId = user.Id;

            //await this.dbService.DbContext.Categories.AddAsync(category);
            //return await this.dbService.DbContext.SaveChangesAsync();
            throw new NotFiniteNumberException();
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
