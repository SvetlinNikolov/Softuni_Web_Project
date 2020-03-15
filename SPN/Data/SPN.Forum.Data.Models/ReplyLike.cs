namespace SPN.Forum.Data.Models
{
    using System;
    using SPN.Forum.Data.Common.Contracts;
    using SPN.Forum.Data.Common.Models;
    using SPN.Forum.Data.Models.Identity;

    public class ReplyLike :BaseEntity<int>, IDeletableEntity
    {
        public virtual User User { get; set; }

        public string UserId { get; set; }

        public virtual Reply Reply { get; set; }

        public int ReplyId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

    }
}
