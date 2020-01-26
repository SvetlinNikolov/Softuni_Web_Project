﻿namespace SPN.Data.Models.Forum
{
    using SPN.Data.Common.Models;
    using SPN.Data.Models.Identity;

    public class ReplyLike : BaseEntity<int>
    {
        public User User { get; set; }
        public string UserId { get; set; }
        public Reply Reply { get; set; }
        public int ReplyId { get; set; }

    }
}