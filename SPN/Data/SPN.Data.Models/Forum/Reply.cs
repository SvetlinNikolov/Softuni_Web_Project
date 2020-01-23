namespace SPN.Data.Models.Forum
{
    using SPN.Data.Common.Contracts;
    using SPN.Data.Common.Models;
    using SPN.Data.Models.Identity;
    using System;
    using System.Collections.Generic;

    public class Reply : BaseEntity<int>, IAuditInfo, IDeletableEntity
    {
        public string Content { get; set; }
        public string AuthorId { get; set; }
        public virtual User Author { get; set; }
        public virtual Post Post { get; set; }
        public int PostId { get; set; }
        public ICollection<ReplyLike> ReplyLikes { get; set; } = new HashSet<ReplyLike>();
        public ICollection<Quote> Quotes { get; set; } = new HashSet<Quote>();
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
