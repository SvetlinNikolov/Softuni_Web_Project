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
    using SPN.Web.InputModels.ForumInputModels.Quote;
    public class QuoteService : BaseService, IQuoteService
    {
        private readonly IReplyService replyService;

        public QuoteService(IMapper mapper, SPNDbContext dbContext, IReplyService replyService)
            : base(mapper, dbContext)
        {
            this.replyService = replyService;
        }

        public async Task CreateQuoteAsync(QuoteInputModel model, User user)
        {
            var reply = await this.replyService.GetReplyByIdAsync(model.Id);

            model.AuthorId = user.Id;
            model.ReplyAuthorId = reply.AuthorId;
            model.ReplyContent = reply.Content;

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
