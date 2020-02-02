namespace SPN.Services.ForumServices
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using SPN.Data;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Services.Contracts.Forum;
    using SPN.Web.ViewModels.ForumInputModels.Post;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;



    public class PostService : IPostService
    {
        private readonly SPNDbContext dbContext;
        private readonly IMapper mapper;

        public PostService(SPNDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<int> CreatePostAsync(PostInputModel model, User user, int categoryId)
        {
            var postCategory = this.dbContext.Categories
                   .FirstOrDefault(c => c.Id == categoryId);

            var post = new Post
            {
                Title = model.Title,
                Content = model.Content,
                Category = postCategory,
                CategoryId = postCategory.Id,
                Author = user,
                AuthorId = user.Id,
                CreatedOn = DateTime.UtcNow,


            };

            await this.dbContext.Posts.AddAsync(post);
            return await this.dbContext.SaveChangesAsync();
        }
        public Task DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditPost(int id)
        {
            throw new NotImplementedException();
        }

        public Post GetPostById(int id)
        {
            return dbContext
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
                .Include(p=> p.PostLikes)
                .FirstOrDefault(p => p.Id == id);

        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Post>> GetPostsByCategoryAsync(int id)
        {

            IEnumerable<Post> posts =
               await dbContext
               .Posts
               .Where(p => p.Id == id)
               .Include(p => p.Author)
               .ToListAsync();

            return posts;
        }
        public int GetTotalPostsCount()
        {
            return 42069;
        }


    }
}
