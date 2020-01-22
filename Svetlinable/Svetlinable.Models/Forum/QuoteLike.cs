namespace Svetlinable.Models.Forum
{
    using Svetlinable.Models.Shared;

    public class QuoteLike
    {
        public User User { get; set; }
        public string UserId { get; set; }
        public Quote Quote { get; set; }
        public int QuoteId { get; set; }
    }
}