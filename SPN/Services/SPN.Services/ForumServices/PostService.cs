namespace SPN.Services.ForumServices
{
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

        public PostService(SPNDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> CreatePost(PostInputModel model, User user, int categoryId)
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
                AuthorId = user.Id

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
                .Find(id);
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetPostsByCategory(int id)
        {

            var posts =
               dbContext
               .Posts
               .Where(p => p.Id == id)
               .Include(p => p.Author)
               .ToList();

            return posts;
        }
        public int GetTotalPostsCount()
        {
            throw new NotFiniteNumberException();
        }


    }
}
