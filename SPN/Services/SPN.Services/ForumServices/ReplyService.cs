namespace SPN.Services.ForumServices
{
    using AutoMapper;
    using SPN.Data;
    using SPN.Data.Models.Forum;
    using SPN.Services.Contracts.Forum;
    using SPN.Services.Shared;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class ReplyService : BaseService, IReplyService
    {
        public ReplyService(IMapper mapper, SPNDbContext dbContext)
            : base(mapper, dbContext)
        {
        }

        public Task<Reply> AddReplyAsync(ReplyInputModel model)
        {
            throw new NotImplementedException();
        }

        public Task<Reply> DeleteReplyAsync(Reply reply)
        {
            throw new NotImplementedException();
        }

        public Task<Reply> EditReplyAsync(int replyId, string newMessage)
        {
            throw new NotImplementedException();
        }

        public Task<Reply> GetReplyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
