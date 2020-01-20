namespace Svetlinable.Models.Forum
{
    using Svetlinable.Models.Shared;

    public class PostLike : BaseEntity<int>
    {
        public string UserId { get; set; }
        public User User { get; set; }

        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
