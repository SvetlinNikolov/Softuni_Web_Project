namespace SPN.Data.Models.Forum
{
    using System;
    using SPN.Data.Common.Contracts;
    using SPN.Data.Common.Models;
    using SPN.Data.Models.Shared.Identity;

    public class ReplyLike : BaseEntity<int>, IDeletableEntity
    {
        public virtual User User { get; set; }

        public string UserId { get; set; }

        public virtual Reply Reply { get; set; }

        public int ReplyId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

    }
}
