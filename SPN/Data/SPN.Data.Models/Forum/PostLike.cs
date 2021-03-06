﻿namespace SPN.Data.Models.Forum
{
    using SPN.Data.Common.Models;
    using SPN.Data.Models.Shared.Identity;

    public class PostLike : BaseEntity<int>
    {
        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}
