namespace Svetlinable.Models.Shared
{
    using System;
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    using Svetlinable.Models.Forum;
    using Svetlinable.Models.Shared.Enums;

    public class User : IdentityUser
    {
        public Gender Gender { get; set; }
        public string ProfileImage { get; set; }
        public DateTime RegisteredOn { get; set; }
        public virtual ICollection<PostLike> PostLikes { get; set; } = new HashSet<PostLike>();        //NOT SURE WHERE TO PUT VIRTUAL
        public virtual ICollection<ReplyLike> ReplyLikes { get; set; } = new HashSet<ReplyLike>();
        public virtual ICollection<Reply> Replies { get; set; } = new HashSet<Reply>();
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
    }
}
