namespace SPN.Forum.Services.Services
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using SPN.Web.ViewModels.ForumViewModels.Post;
    using SPN.Forum.Data;
    using SPN.Forum.Services.Contracts;
    using SPN.Forum.Services.Shared;
    using SPN.Forum.Web.InputModels.Post;
    using SPN.Forum.Data.Models;

    public class PostService : BaseService, IPostService
    {
        private readonly IUserService userService;

        public PostService(IMapper mapper, SPNDbContext dbContext, IUserService userService)
            : base(mapper, dbContext)
        {
            this.userService = userService;
        }

        public async Task CreatePostAsync(PostInputModel model)
        {
            var user = await userService.GetLoggedInUserAsync();

            var postCategory = await dbContext.Categories
                   .FirstOrDefaultAsync(c => c.Id == model.Id);

            var post = new Post
            {
                Title = model.Title,
                Content = model.Content,
                CategoryId = postCategory.Id,
                AuthorId = user.Id,
                CreatedOn = DateTime.UtcNow,
            };

            await dbContext.Posts.AddAsync(post);
            await dbContext.SaveChangesAsync();

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
            return await dbContext
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

            var posts = await dbContext
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
            var post = await GetPostByIdAsync(postId);

            var model = mapper.Map<Post, PostIndexViewModel>(post);

            return model;
        }
    }
}
