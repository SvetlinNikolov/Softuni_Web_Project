namespace SPN.Forum.Services.Services
{
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Shared.Identity;
    using SPN.Forum.Data;
    using SPN.Forum.Services.Contracts;

    using SPN.Forum.Web.InputModels.PostLike;
    using SPN.Services.Shared;

    public class PostLikeService : BaseService, IPostLikeService
    {

        public PostLikeService(IMapper mapper, SPNDbContext dbContext)
            : base(mapper, dbContext)
        {
        }

        public async Task DislikePostAsync(int postId, User user)
        {
            var likeExists = await GetPostLikeAsync(user.Id, postId);

            if (likeExists != null)
            {
                dbContext.PostLikes.Remove(likeExists);
                await dbContext.SaveChangesAsync();
            }
            //TODO mayble implement some kind of error here
        }

        public async Task LikePostAsync(PostLikeInputModel model, User user)
        {
            var post = await dbContext.Posts.FindAsync(model.PostId);

            var postLike = new PostLike
            {
                PostId = model.PostId,
                UserId = model.LikeAuthor
            };

            await dbContext.SaveChangesAsync();
        }

        public async Task<PostLike> GetPostLikeAsync(string userId, int postId)
        {
            var likeExists = await dbContext
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
