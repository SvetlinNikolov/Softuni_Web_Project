namespace SPN.Services.Contracts.Forum
{
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Web.InputModels.ForumInputModels.Post;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IPostService
    {
        Task<Post> GetPostByIdAsync(int id);
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        Task<IEnumerable<Post>> GetPostsByCategoryAsync(int searchQuery);
        Task<int> CreatePostAsync(PostInputModel model, User user);
        Task DeletePost(int id);
        Task EditPost(int id);
        int GetTotalPostsCount();

    }
}
