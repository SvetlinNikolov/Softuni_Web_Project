﻿namespace Svetlinable.Models.Forum
{
    using System;
    using System.Collections.Generic;

    using Svetlinable.Models.Shared;

    public class Reply : BaseEntity<int>
    {
        public string Description { get; set; }
        public string AuthorId { get; set; }
        public User Author { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual ICollection<ReplyLike> ReplyLikes { get; set; } = new HashSet<ReplyLike>();

    }
}
