namespace SPN.Services.ForumServices
{
    using System;
    using SPN.Data;
    using SPN.Data.Models.Forum;
    using SPN.Services.Contracts.Forum;
    public class PostLikeService : IPostLikeService
    {
        private readonly SPNDbContext dbContext;

        public PostLikeService(SPNDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void DislikePost(string userId, int postId)
        {
            throw new NotImplementedException();
        }

        public PostLike GetLikeByAuthorIdAndPostId(string userId, int postId)
        {
            throw new NotImplementedException();
        }

        public void LikePost(PostLike like)
        {
            //var userId = this.User.Identity.GetUserId();
            //var isLiked = this.Data.PostLikes.All().Any(l => l.PostId == id && l.UserId == userId && !l.IsDeleted);
            //var likesCount = this.Data.PostLikes.All().Count(p => p.PostId == id);

            //var model = new PostLikeInputModel
            //{
            //    PostId = post.Id,
            //    IsLiked = isLiked,
            //    LikesCount = likesCount,
            //    PostAuthorId = post.AuthorId
            //};

        }
    }
}
