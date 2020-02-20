namespace SPN.Services.Contracts.Forum
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Web.InputModels.ForumInputModels.Post;
    using SPN.Web.ViewModels.ForumViewModels.Post;
 
    public interface IPostService
    {
        Task<Post> GetPostByIdAsync(int postId);
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        Task<IEnumerable<Post>> GetPostsByCategoryAsync(int searchQuery);
        Task CreatePostAsync(PostInputModel model);
        Task DeletePost(int id);
        Task EditPost(int id);
        Task<PostIndexViewModel> GetPostIndexViewModelAsync(int postId);

    }
}
