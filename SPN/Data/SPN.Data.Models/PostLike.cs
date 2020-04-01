namespace SPN.Forum.Data.Models
{
    using SPN.Data.Common.Models;
    using SPN.Forum.Data.Models.Identity;

    public class PostLike : BaseEntity<int>
    {
        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}
