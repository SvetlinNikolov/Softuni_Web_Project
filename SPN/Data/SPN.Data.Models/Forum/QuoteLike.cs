using SPN.Data.Common.Models;
using SPN.Data.Models.Identity;

namespace SPN.Data.Models.Forum
{

    public class QuoteLike : BaseEntity<int>
    {
        public User User { get; set; }
        public string UserId { get; set; }
        public Quote Quote { get; set; }
        public int QuoteId { get; set; }
    }
}