
namespace Svetlinable.Models.Forum
{
    using System;
    using System.Collections.Generic;

    using Svetlinable.Models.Shared;


    public class Quote : BaseEntity<int>
    {
        public string Content { get; set; }
        public string AuthorId { get; set; }
        public virtual User Author { get; set; }
        public virtual Reply Reply { get; set; }
        public int ReplyId { get; set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<QuoteLike> QuoteLikes { get; set; } = new HashSet<QuoteLike>();
    }
}
