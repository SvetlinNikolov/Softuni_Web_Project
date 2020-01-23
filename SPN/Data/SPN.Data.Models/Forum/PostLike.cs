using SPN.Data.Common.Contracts;
using SPN.Data.Common.Models;
using SPN.Data.Models.Identity;

namespace SPN.Data.Models.Forum
{


    public class PostLike : BaseEntity<int>
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
