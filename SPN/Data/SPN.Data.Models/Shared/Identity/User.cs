namespace SPN.Data.Models.Shared.Identity
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;
    using SPN.Data.Common.Contracts;
    using SPN.Data.Models.Auto;
    using SPN.Data.Models.Auto.Enums;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Shared.Identity.Enums;

    public class User : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public User()
        {
            PostLikes = new HashSet<PostLike>();
            ReplyLikes = new HashSet<ReplyLike>();
            QuoteLikes = new HashSet<QuoteLike>();
            Replies = new HashSet<Reply>();
            Posts = new HashSet<Post>();
            Quotes = new HashSet<Quote>();
            Automobiles = new HashSet<Automobile>();
        }

        public string ProfileImage { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<PostLike> PostLikes { get; set; }

        public virtual ICollection<ReplyLike> ReplyLikes { get; set; }

        public virtual ICollection<QuoteLike> QuoteLikes { get; set; }

        public virtual ICollection<Reply> Replies { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public virtual ICollection<Quote> Quotes { get; set; }

        public virtual ICollection<Automobile> Automobiles { get; set; }
    }
}
