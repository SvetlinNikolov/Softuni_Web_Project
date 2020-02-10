
namespace SPN.Data.Models.Identity
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    using SPN.Data.Common.Contracts;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity.Enums;
    using SPN.Data.Models.Quiz;

    public class User : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public User()
        {
            this.PostLikes = new HashSet<PostLike>();
            this.ReplyLikes = new HashSet<ReplyLike>();
            this.QuoteLikes = new HashSet<QuoteLike>();
            this.Replies = new HashSet<Reply>();
            this.Posts = new HashSet<Post>();
            this.Quotes = new HashSet<Quote>();
        }
        public Gender Gender { get; set; }

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

        public virtual ICollection<Contest> ContestsCreated { get; set; }

    }
}
