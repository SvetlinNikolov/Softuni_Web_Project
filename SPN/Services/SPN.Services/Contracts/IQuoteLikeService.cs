namespace SPN.Forum.Services.Contracts
{
    using SPN.Forum.Data.Models.Forum;

    public interface IQuoteLikeService
    {
        QuoteLike GetLikeByAuthorIdAndQuoteId(string userId, int quoteId);
        void DislikeQuote(string userId, int quoteId);
        void LikeQuote(QuoteLike like);
    }
}
