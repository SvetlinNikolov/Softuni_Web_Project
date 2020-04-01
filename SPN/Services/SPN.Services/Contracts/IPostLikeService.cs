namespace SPN.Forum.Services.Contracts
{
    using System.Threading.Tasks;
    using SPN.Forum.Data.Models;
    using SPN.Forum.Data.Models.Identity;
    using SPN.Forum.Web.InputModels.PostLike;

    public interface IPostLikeService
    {
        Task DislikePostAsync(int postId, User user);
        Task LikePostAsync(PostLikeInputModel model, User user);
        Task<PostLike> GetPostLikeAsync(string userId, int postId);

    }
}
