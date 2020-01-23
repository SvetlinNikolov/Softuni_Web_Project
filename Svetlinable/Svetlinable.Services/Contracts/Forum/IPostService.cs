namespace Svetlinable.Services.Contracts.Forum
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Svetlinable.Models.Forum;

    public interface IPostService
    {
        Post GetPostById(int id);
        IEnumerable<Post> GetAllPosts();
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        IEnumerable<Post> GetPostsByCategory(int searchQuery);
        Task AddPost(Post post);
        Task DeletePost(int id);
        Task EditPost(int id);

    }
}
