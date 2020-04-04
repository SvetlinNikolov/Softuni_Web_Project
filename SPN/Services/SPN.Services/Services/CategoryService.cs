namespace SPN.Forum.Services.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using SPN.Forum.Data;
    using SPN.Forum.Data.Models;
    using SPN.Forum.Services.Contracts;

    using SPN.Forum.Web.InputModels.Category;
    using SPN.Services.Shared;
    using SPN.Web.ViewModels.ForumViewModels.CategoryViewModels;
    using SPN.Web.ViewModels.ForumViewModels.Post;

    public class CategoryService : BaseService, ICategoryService
    {
        private readonly IPostService postService;

        public CategoryService(IMapper mapper, SPNDbContext dbContext, IPostService postService)
            : base(mapper, dbContext)
        {
            this.postService = postService;
        }

        public async Task CreateCategoryAsync(CategoryInputModel inputModel)
        {
            Category category = mapper.Map<Category>(inputModel); //Maping

            await dbContext.Categories.AddAsync(category);
            await dbContext.SaveChangesAsync();

            inputModel.Id = category.Id;
        }

        public Task DeleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            var category = await dbContext
                    .Categories
                    .Where(c => c.Id == id)
                    .Include(x => x.Posts)
                    .SingleOrDefaultAsync();

            return category;
        }

        public async Task UpdateCategoryDescriptionAsync(int categoryId, string newDescription)
        {
            Category categoryToUpdate = await GetCategoryByIdAsync(categoryId);
            categoryToUpdate.Description = newDescription;

            dbContext.Update(categoryToUpdate);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateCategoryTitleAsync(int categoryId, string newTitle)
        {
            Category category = await GetCategoryByIdAsync(categoryId);
            category.Title = newTitle;

            dbContext.Update(category);
            await dbContext.SaveChangesAsync();
        }

        public async Task<CategoryListingViewModel> GetAllCategoriesAsync()
        {
            var categories = await dbContext
                    .Categories
                    .Include(x => x.Posts)
                    .ToListAsync();

            var categoryModel = mapper
                 .Map<IEnumerable<CategoryConciseViewModel>>(categories); //Map

            var model = new CategoryListingViewModel
            {
                CategoryListing = categoryModel
            };

            return model;
        }

        public async Task<CategoryTopicModel> GetCategoryTopic(int categoryId)
        {
            var category = await GetCategoryByIdAsync(categoryId);
            var posts = await postService.GetPostsByCategoryAsync(categoryId);

            var categoryConcise = mapper
                .Map<CategoryConciseViewModel>(category);

            var postListing = mapper
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
