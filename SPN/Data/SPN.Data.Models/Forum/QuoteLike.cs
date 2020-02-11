
namespace SPN.Data.Models.Forum
{
    using SPN.Data.Common.Contracts;
    using SPN.Data.Common.Models;
    using SPN.Data.Models.Identity;
    using System;

    public class QuoteLike : BaseEntity<int>
    {
        public virtual User User { get; set; }
        public string UserId { get; set; }
        public virtual Quote Quote { get; set; }
        public int QuoteId { get; set; }
        
    }
}