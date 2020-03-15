namespace SPN.Services.ForumServices
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using SPN.Forum.Data;
    using SPN.Forum.Data.Models.Forum;
    using SPN.Services.Shared;
    using SPN.Web.InputModels.ForumInputModels.Post;
    using SPN.Web.ViewModels.ForumViewModels.Post;
    using SPN.Forum.Services.Contracts;

    public class PostService : BaseService, IPostService
    {
        private readonly IUserService userService;

        public PostService(IMapper mapper, SPNDbContext dbContext,IUserService userService)
            : base(mapper, dbContext)
        {
            this.userService = userService;
        }

        public async Task CreatePostAsync(PostInputModel model)
        {
            var user = await this.userService.GetLoggedInUserAsync();

            var postCategory = await this.dbContext.Categories
                   .FirstOrDefaultAsync(c => c.Id == model.Id);

            var post = new Post
            {
                Title = model.Title,
                Content = model.Content,
                CategoryId = postCategory.Id,
                AuthorId = user.Id,
                CreatedOn = DateTime.UtcNow,
            };

            await this.dbContext.Posts.AddAsync(post);
            await this.dbContext.SaveChangesAsync();

            model.Id = post.Id;

        }
        public Task DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditPost(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Post> GetPostByIdAsync(int id)
        {
            return await this.dbContext
                .Posts
                .Include(p => p.Category)
                .Include(p => p.Author)
                .ThenInclude(p => p.Posts)
                .Include(p => p.Replies)
                .ThenInclude(p => p.Author)
                .ThenInclude(p => p.Posts)
                .Include(p => p.Replies)
                .ThenInclude(p => p.Quotes)
                .Include(p => p.Replies)
                .ThenInclude(p => p.Quotes)
                .ThenInclude(p => p.Author)
                .ThenInclude(p => p.Posts)
                .Include(p => p.PostLikes)
                .FirstOrDefaultAsync(p => p.Id == id);

        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Post>> GetPostsByCategoryAsync(int id)
        {

            var posts = await this.dbContext
                .Posts
                .Include(p => p.Category)
                .Include(p => p.Author)
                .ThenInclude(p => p.Posts)
                .Include(p => p.Replies)
                .ThenInclude(p => p.Author)
                .ThenInclude(p => p.Posts)
                .Include(p => p.Replies)
                .ThenInclude(p => p.Quotes)
                .Include(p => p.Replies)
                .ThenInclude(p => p.Quotes)
                .ThenInclude(p => p.Author)
                .ThenInclude(p => p.Posts)
                .Include(p => p.PostLikes)
                .Where(p => p.CategoryId == id)
                .ToListAsync();

            return posts;
        }

        public async Task<PostIndexViewModel> GetPostIndexViewModelAsync(int postId)
        {
            var post = await this.GetPostByIdAsync(postId);

            var model = this.mapper.Map<Post, PostIndexViewModel>(post);

            return model;
        }
    }
}
