namespace SPN.Services.Contracts.Forum
{
    using System.Threading.Tasks;

    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Web.InputModels.ForumInputModels.Quote;
 
    public interface IQuoteService
    {
        Task CreateQuoteAsync(QuoteInputModel model);
        Task DeleteQuoteAsync(int id);
        Task<Quote> GetQuoteByIdAsync(int id);
        Task<Quote> EditQuoteAsync(int quoteId, string newMessage);
    }
}
