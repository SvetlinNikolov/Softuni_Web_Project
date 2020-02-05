namespace SPN.Services.ForumServices
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using SPN.Data;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Services.Contracts.Forum;
    using SPN.Services.Shared;
    using SPN.Web.InputModels.ForumInputModels.Quote;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class QuoteService : BaseService, IQuoteService
    {
        public QuoteService(IMapper mapper, SPNDbContext dbContext)
            : base(mapper, dbContext)
        {
        }

        public async Task<int> CreateQuoteAsync(QuoteInputModel model, User user)
        {
            var reply = await this.dbContext.Replies
                  .FirstOrDefaultAsync(r => r.Id == model.ReplyId);

            var quote = new Quote
            {
                ReplyId = model.ReplyId,
                Content = model.Content,
                AuthorId = user.Id,
                CreatedOn = DateTime.UtcNow,
            };

            await this.dbContext.Quotes.AddAsync(quote);
            return await this.dbContext.SaveChangesAsync();

        }

        public Task<int> DeleteQuoteAsync(int id)
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
