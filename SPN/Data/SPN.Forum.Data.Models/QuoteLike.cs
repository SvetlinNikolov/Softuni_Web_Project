
namespace SPN.Forum.Data.Models
{
    using SPN.Data.Common.Models;
    using SPN.Forum.Data.Models.Identity;
    using System;

    public class QuoteLike : BaseEntity<int>
    {
        public virtual User User { get; set; }

        public string UserId { get; set; }

        public virtual Quote Quote { get; set; }

        public int QuoteId { get; set; }
        
    }
}