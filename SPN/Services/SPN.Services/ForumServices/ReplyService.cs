namespace SPN.Services.ForumServices
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using SPN.Data;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Services.Contracts.Forum;
    using SPN.Services.Shared;
    using SPN.Web.InputModels.ForumInputModels.Reply;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class ReplyService : BaseService, IReplyService
    {
        private readonly IPostService postService;

        public ReplyService(IMapper mapper, SPNDbContext dbContext,IPostService postService)
            : base(mapper, dbContext)
        {
            this.postService = postService;
        }

        public async Task<int> AddReplyAsync(ReplyInputModel model, User user)
        {
            var post = await this.postService.GetPostByIdAsync(model.PostId);

            Reply reply = new Reply
            {
                Author = user,
                AuthorId =user.Id,
                Content = model.Content,
                CreatedOn = DateTime.UtcNow,
                Post = post,
                PostId = post.Id
            };

            await this.dbContext.Posts.AddAsync(post);
            return await this.dbContext.SaveChangesAsync();
        }

        public Task<Reply> DeleteReplyAsync(Reply reply)
        {
            throw new NotImplementedException();
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
