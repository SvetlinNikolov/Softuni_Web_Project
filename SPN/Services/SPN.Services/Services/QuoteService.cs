namespace SPN.Forum.Services.Services
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Threading.Tasks;
    using SPN.Forum.Data;
    using SPN.Forum.Services.Contracts;
    using SPN.Forum.Services.Shared;
    using SPN.Forum.Web.InputModels.Quote;
    using SPN.Forum.Data.Models;

    public class QuoteService : BaseService, IQuoteService
    {
        private readonly IReplyService replyService;
        private readonly IUserService userService;

        public QuoteService(IMapper mapper, SPNDbContext dbContext, IReplyService replyService, IUserService userService)
            : base(mapper, dbContext)
        {
            this.replyService = replyService;
            this.userService = userService;
        }

        public async Task CreateQuoteAsync(QuoteInputModel model)
        {
            var reply = await replyService.GetReplyByIdAsync(model.Id);
            var user = await userService.GetLoggedInUserAsync();

            model.AuthorId = user.Id;
            model.ReplyAuthorId = reply.AuthorId;
            model.ReplyContent = reply.Content;
            model.ReplyAuthorName = reply.Author.UserName;

            var quote = mapper.Map<QuoteInputModel, Quote>(model);

            await dbContext.Quotes.AddAsync(quote);
            await dbContext.SaveChangesAsync();

        }

        public Task DeleteQuoteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Quote> EditQuoteAsync(int quoteId, string newMessage)
        {
            throw new NotImplementedException();
        }

        public async Task<Quote> GetQuoteByIdAsync(int id)
        {
            return await dbContext
                .Quotes
                .Include(q => q.Author)
                .Include(q => q.QuoteLikes)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
