namespace Svetlinable.Models.Forum
{
    using System;
    using System.Collections.Generic;

    using Svetlinable.Models.Shared;

    public class Category : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
    }
}
