using SPN.Data.Models.Forum;

namespace SPN.Services.Contracts.Forum
{
  
    public interface IQuoteLikeService
    {
        QuoteLike GetLikeByAuthorIdAndQuoteId(string userId, int quoteId);
        void DislikeQuote(string userId, int quoteId);
        void LikeQuote(QuoteLike like);
    }
}
