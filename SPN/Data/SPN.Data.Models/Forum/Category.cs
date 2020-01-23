namespace SPN.Data.Models.Forum
{
    using System;
    using System.Collections.Generic;

    using SPN.Data.Common.Contracts;
    using SPN.Data.Common.Models;

    public class Category : BaseEntity<int>, IAuditInfo, IDeletableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
