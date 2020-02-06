namespace SPN.Services.ForumServices
{
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;

    using SPN.Data;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Services.Contracts.Forum;
    using SPN.Services.Shared;
    using SPN.Web.InputModels.ForumInputModels.PostLike;

    public class PostLikeService : BaseService, IPostLikeService
    {

        public PostLikeService(IMapper mapper, SPNDbContext dbContext)
            : base(mapper, dbContext)
        {
        }

        public async Task DislikePostAsync(int postId, User user)
        {
            var likeExists = await this.GetPostLikeAsync(user.Id, postId);

            if (likeExists != null)
            {
                this.dbContext.PostLikes.Remove(likeExists);
                await this.dbContext.SaveChangesAsync();
            }
            //TODO mayble implement some kind of error here
        }

        public async Task LikePostAsync(PostLikeInputModel model, User user)
        {
            var post = await this.dbContext.Posts.FindAsync(model.PostId);

            var postLike = new PostLike
            {
                PostId = model.PostId,
                UserId = model.LikeAuthor
            };

            await this.dbContext.SaveChangesAsync();
        }

        public async Task<PostLike> GetPostLikeAsync(string userId, int postId)
        {
            var likeExists = await this.dbContext
              .PostLikes
              .FirstOrDefaultAsync(p => p.PostId == postId && p.UserId == userId);

            if (likeExists != null)
            {
                return likeExists;
            }

            return null;
        }
    }
}
