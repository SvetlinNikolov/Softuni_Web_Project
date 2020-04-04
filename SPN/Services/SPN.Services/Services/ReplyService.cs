namespace SPN.Forum.Services.Services
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Threading.Tasks;
    using System.Linq;
    using SPN.Forum.Data;
    using SPN.Forum.Data.Models.Identity;
    using SPN.Forum.Services.Contracts;
    using SPN.Forum.Web.InputModels.Reply;
    using SPN.Forum.Data.Models;
    using SPN.Services.Shared;

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
            var post = await postService.GetPostByIdAsync(model.Id);

            Reply reply = new Reply
            {
                AuthorId = user.Id,
                Content = model.Content,
                CreatedOn = DateTime.UtcNow,
                PostId = post.Id
            };

            await dbContext.Replies.AddAsync(reply);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteReplyAsync(int id)
        {
            var replyToDelete = await dbContext.Replies.FindAsync(id);

            dbContext.Replies.Remove(replyToDelete);

            await dbContext.SaveChangesAsync();
        }

        public Task<Reply> EditReplyAsync(int replyId, string newMessage)
        {
            throw new NotImplementedException();
        }

        public async Task<Reply> GetReplyByIdAsync(int id)
        {
            return await dbContext
                  .Replies
                  .Include(r => r.Quotes)
                  .Include(r => r.ReplyLikes)
                  .Include(r => r.Post)
                  .Include(r => r.Author)
                  .FirstOrDefaultAsync();
        }

        public async Task<string> GetReplyContent(int replyId)
        {
            var reply = await dbContext
                .Replies
                .Where(x => x.Id == replyId)
                .Select(x => x.Content)
                .FirstOrDefaultAsync();

            return reply;

        }
    }
}
