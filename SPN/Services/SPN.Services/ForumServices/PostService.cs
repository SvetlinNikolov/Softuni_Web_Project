namespace SPN.Services.ForumServices
{
    using SPN.Data;
    using SPN.Data.Models.Forum;
    using SPN.Services.Contracts.Forum;
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
            return dbContext
                .Categories
                .Where(f => f.Id == id)
                .FirstOrDefault()
                .Posts;


        }
    }
}
