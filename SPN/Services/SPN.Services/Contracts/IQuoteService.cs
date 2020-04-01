namespace SPN.Forum.Services.Contracts
{
    using System.Threading.Tasks;
    using SPN.Forum.Data.Models;
    using SPN.Forum.Web.InputModels.Quote;

    public interface IQuoteService
    {
        Task CreateQuoteAsync(QuoteInputModel model);
        Task DeleteQuoteAsync(int id);
        Task<Quote> GetQuoteByIdAsync(int id);
        Task<Quote> EditQuoteAsync(int quoteId, string newMessage);
    }
}
