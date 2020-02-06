
namespace SPN.Data.Models.Identity
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Identity;

    using SPN.Data.Common.Contracts;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity.Enums;


    public class User : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public Gender Gender { get; set; }
        public string ProfileImage { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public ICollection<PostLike> PostLikes { get; set; } = new HashSet<PostLike>();        //NOT SURE WHERE TO PUT VIRTUAL
        public ICollection<ReplyLike> ReplyLikes { get; set; } = new HashSet<ReplyLike>();
        public ICollection<QuoteLike> QuoteLikes { get; set; } = new HashSet<QuoteLike>();
        public ICollection<Reply> Replies { get; set; } = new HashSet<Reply>();
        public ICollection<Post> Posts { get; set; } = new HashSet<Post>();
        public ICollection<Quote> Quotes { get; set; } = new HashSet<Quote>();

    }
}
