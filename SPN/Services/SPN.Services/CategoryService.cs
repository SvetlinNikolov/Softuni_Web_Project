namespace SPN.Services.ForumServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;

    using SPN.Forum.Data;
    using SPN.Forum.Data.Models.Forum;
    using SPN.Forum.Services.Contracts;
    using SPN.Services.Shared;
    using SPN.Web.InputModels.ForumInputModels.Category;
    using SPN.Web.ViewModels.ForumViewModels.CategoryViewModels;
    using SPN.Web.ViewModels.ForumViewModels.Post;

    public class CategoryService : BaseService, ICategoryService
    {
        private readonly IPostService postService;

        public CategoryService(IMapper mapper, SPNDbContext dbContext,IPostService postService)
            : base(mapper, dbContext)
        {
            this.postService = postService;
        }

        public async Task CreateCategoryAsync(CategoryInputModel inputModel)
        {
            Category category = this.mapper.Map<Category>(inputModel); //Maping
            
            await this.dbContext.Categories.AddAsync(category);
            await this.dbContext.SaveChangesAsync();

            inputModel.Id = category.Id;
        }

        public Task DeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            var category = await this.dbContext
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

       public async Task<CategoryListingViewModel> GetAllCategoriesAsync()
        {
            var categories = await this.dbContext
                    .Categories
                    .Include(x => x.Posts)
                    .ToListAsync();

            var categoryModel = this.mapper
                 .Map<IEnumerable<CategoryConciseViewModel>>(categories); //Map

            var model = new CategoryListingViewModel
            {
                CategoryListing = categoryModel
            };

            return model;
        }

        public async Task<CategoryTopicModel> GetCategoryTopic(int categoryId)
        {
            var category = await this.GetCategoryByIdAsync(categoryId);
            var posts = await postService.GetPostsByCategoryAsync(categoryId);

            var categoryConcise = this.mapper
                .Map<CategoryConciseViewModel>(category);

            var postListing = this.mapper
                .Map<IEnumerable<PostListingViewModel>>(posts);

            var model = new CategoryTopicModel
            {
                Category = categoryConcise,
                Posts = postListing
            };

            return model;
        }
    }
}
