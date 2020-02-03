namespace SPN.Services.ForumServices
{
    using System;
    using System.Threading.Tasks;
    using AutoMapper;
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

        public Task DislikePost(int? postId)
        {
            throw new NotImplementedException();
        }

        public Task LikePost(PostLikeInputModel model, User user)
        {
            var post = this.dbContext.Posts.Find(model.PostId);

            throw new NotFiniteNumberException();
        }
    }
}
