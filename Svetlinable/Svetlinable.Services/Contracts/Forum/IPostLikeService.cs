
namespace Svetlinable.Services.Contracts.Forum
{
    using Svetlinable.Models.Forum;

    public interface IPostLikeService
    {
        PostLike GetLikeByAuthorIdAndPostId(string userId, int postId);
        void DislikePost(string userId, int postId);
        void LikePost(PostLike like);

    }
}
