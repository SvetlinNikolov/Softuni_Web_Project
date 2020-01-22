namespace Svetlinable.Models.Forum
{
    using Svetlinable.Models.Shared;
    public class ReplyLike : BaseEntity<int>
    {
        public User User { get; set; }
        public string UserId { get; set; }
        public Reply Reply { get; set; }
        public int ReplyId { get; set; }

    }
}
