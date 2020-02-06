namespace SPN.Services.Contracts.Forum
{
    using System.Threading.Tasks;

    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Web.InputModels.ForumInputModels.PostLike;

    public interface IPostLikeService
    { 
        Task DislikePostAsync(int postId, User user);
        Task LikePostAsync(PostLikeInputModel model, User user);
        Task<PostLike> GetPostLikeAsync(string userId, int postId);

    }
}
