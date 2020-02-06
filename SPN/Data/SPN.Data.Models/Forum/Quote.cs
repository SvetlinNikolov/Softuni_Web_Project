namespace SPN.Data.Models.Forum
{
    using System;
    using System.Collections.Generic;

    using SPN.Data.Common.Contracts;
    using SPN.Data.Common.Models;
    using SPN.Data.Models.Identity;
 
    public class Quote : BaseEntity<int>, IAuditInfo, IDeletableEntity
    {
        public string Content { get; set; }
        public string AuthorId { get; set; }
        public virtual User Author { get; set; }
        public virtual Reply Reply { get; set; }
        public int ReplyId { get; set; }
        public ICollection<QuoteLike> QuoteLikes { get; set; } = new HashSet<QuoteLike>();
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
