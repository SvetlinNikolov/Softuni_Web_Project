namespace Svetlinable.Models.Forum
{
    using Svetlinable.Models.Shared;
    using System;
    using System.Collections.Generic;

    public class Category : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
    }
}
