namespace Svetlinable.Models.Forum
{
    using System;
    using System.Collections.Generic;

    using Svetlinable.Models.Shared;
    public class Post : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Views { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string AuthorId { get; set; }
        public virtual User Author { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<PostLike> PostLikes { get; set; } = new HashSet<PostLike>(); //TODO I left it virtual
        public virtual ICollection<Reply> Replies { get; set; } = new HashSet<Reply>();


    }
}
