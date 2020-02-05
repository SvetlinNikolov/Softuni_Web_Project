namespace SPN.Services.Contracts.Forum
{
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Web.InputModels.ForumInputModels.Quote;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IQuoteService
    {
        Task<int> CreateQuoteAsync(QuoteInputModel model, User user);
        Task<int> DeleteQuoteAsync(int id);
        Task<Quote> GetQuoteByIdAsync(int id);
        Task<Quote> EditQuoteAsync(int quoteId, string newMessage);
    }
}
