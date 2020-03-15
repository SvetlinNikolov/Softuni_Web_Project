namespace SPN.Services.ForumServices
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Threading.Tasks;

    using SPN.Forum.Data;
    using SPN.Forum.Data.Models.Forum;
    using SPN.Forum.Data.Models.Identity;
    using SPN.Services.Shared;
    using SPN.Web.InputModels.ForumInputModels.Quote;
    using SPN.Forum.Services.Contracts.Forum;

    public class QuoteService : BaseService, IQuoteService
    {
        private readonly IReplyService replyService;
        private readonly IUserService userService;

        public QuoteService(IMapper mapper, SPNDbContext dbContext, IReplyService replyService,IUserService userService)
            : base(mapper, dbContext)
        {
            this.replyService = replyService;
            this.userService = userService;
        }

        public async Task CreateQuoteAsync(QuoteInputModel model)
        {
            var reply = await this.replyService.GetReplyByIdAsync(model.Id);
            var user = await this.userService.GetLoggedInUserAsync();

            model.AuthorId = user.Id;
            model.ReplyAuthorId = reply.AuthorId;
            model.ReplyContent = reply.Content;
            model.ReplyAuthorName = reply.Author.UserName;

            var quote = this.mapper.Map<QuoteInputModel, Quote>(model);

            await this.dbContext.Quotes.AddAsync(quote);
            await this.dbContext.SaveChangesAsync();

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
            return await this.dbContext
                .Quotes
                .Include(q => q.Author)
                .Include(q => q.QuoteLikes)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
