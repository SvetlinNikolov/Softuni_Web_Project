namespace SPN.Services.ForumServices
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Threading.Tasks;

    using SPN.Data;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Services.Contracts.Forum;
    using SPN.Services.Shared;
    using SPN.Web.InputModels.ForumInputModels.Reply;
    public class ReplyService : BaseService, IReplyService
    {
        private readonly IPostService postService;
        private readonly IUserService userService;

        public ReplyService(
            IMapper mapper,
            SPNDbContext dbContext,
            IPostService postService,
            IUserService userService
            ) : base(mapper, dbContext)
        {
            this.postService = postService;
            this.userService = userService;
        }

        public async Task CreateReplyAsync(ReplyInputModel model, User user)
        {
            var post = await this.postService.GetPostByIdAsync(model.Id);

            Reply reply = new Reply
            {
                AuthorId = user.Id,
                Content = model.Content,
                CreatedOn = DateTime.UtcNow,
                PostId = post.Id
            };

            await this.dbContext.Replies.AddAsync(reply);
             await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteReplyAsync(int id)
        {
            var replyToDelete = await this.dbContext.Replies.FindAsync(id);

            this.dbContext.Replies.Remove(replyToDelete);

             await this.dbContext.SaveChangesAsync();
        }

        public Task<Reply> EditReplyAsync(int replyId, string newMessage)
        {
            throw new NotImplementedException();
        }

        public async Task<Reply> GetReplyByIdAsync(int id)
        {
            return await this.dbContext
                  .Replies
                  .Include(r => r.Quotes)
                  .Include(r => r.ReplyLikes)
                  .Include(r => r.Post)
                  .Include(r => r.Author)
                  .FirstOrDefaultAsync();
        }

    }
}
