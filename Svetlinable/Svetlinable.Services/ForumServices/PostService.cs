namespace Svetlinable.Services.ForumServices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Svetlinable.Data;
    using Svetlinable.Models.Forum;
    using Svetlinable.Services.Contracts.Forum;

    public class PostService : IPostService
    {
        private readonly SvetlinableDbContext dbContext;

        public PostService(SvetlinableDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        public Task DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditPost(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetPostsByCategory(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public Post GetPostById(int id)
        {
            return this.dbContext
                .Posts
                .Find(id);
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetPostsByCategory(int id)
        {
            return this.dbContext
                .Categories
                .Where(f => f.Id == id)
                .FirstOrDefault()
                .Posts;
                
           
        }
    }
}
