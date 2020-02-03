namespace SPN.Services.Contracts.Forum
{
    using SPN.Data.Models.Forum;
    using SPN.Web.InputModels.ForumInputModels.PostLike;
    using System.Threading.Tasks;

    public interface IPostLikeService
    { 
        Task DislikePost(int? postId);
        Task LikePost(PostLikeInputModel model);

    }
}
