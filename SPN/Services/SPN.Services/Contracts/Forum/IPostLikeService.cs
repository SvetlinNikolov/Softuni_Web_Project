using SPN.Data.Models.Forum;

namespace SPN.Services.Contracts.Forum
{

    public interface IPostLikeService
    {
        PostLike GetLikeByAuthorIdAndPostId(string userId, int postId);
        void DislikePost(string userId, int postId);
        void LikePost(PostLike like);

        //TODO FIX THIS :(

    }
}
