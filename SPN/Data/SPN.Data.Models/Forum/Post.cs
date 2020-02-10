﻿namespace SPN.Data.Models.Forum
{
    using System;
    using System.Collections.Generic;

    using SPN.Data.Common.Contracts;
    using SPN.Data.Common.Models;
    using SPN.Data.Models.Identity;
    public class Post : BaseEntity<int>, IDeletableEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int Views { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string AuthorId { get; set; }
        public virtual User Author { get; set; }
        public virtual ICollection<PostLike> PostLikes { get; set; } = new HashSet<PostLike>(); //TODO I left it virtual
        public virtual ICollection<Reply> Replies { get; set; } = new HashSet<Reply>();
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
