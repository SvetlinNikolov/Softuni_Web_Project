
namespace Svetlinable.Services.Contracts.Forum
{
    using Svetlinable.Models.Forum;
    public interface IQuoteLikeService
    {
        QuoteLike GetLikeByAuthorIdAndQuoteId(string userId, int quoteId);
        void DislikeQuote(string userId, int quoteId);
        void LikeQuote(QuoteLike like);
    }
}
