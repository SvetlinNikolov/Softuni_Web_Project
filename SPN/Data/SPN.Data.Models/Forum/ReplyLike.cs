namespace SPN.Data.Models.Forum
{
    using System;

    using SPN.Data.Common.Contracts;
    using SPN.Data.Common.Models;
    using SPN.Data.Models.Identity;

    public class ReplyLike :BaseEntity<int>, IDeletableEntity
    {
        public User User { get; set; }
        public string UserId { get; set; }
        public Reply Reply { get; set; }
        public int ReplyId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }

    }
}
