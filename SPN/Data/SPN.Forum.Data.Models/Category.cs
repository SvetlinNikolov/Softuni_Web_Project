namespace SPN.Forum.Data.Models
{
    using SPN.Data.Common.Contracts;
    using SPN.Data.Common.Models;
    using System;
    using System.Collections.Generic;

    public class Category : BaseEntity<int>, IDeletableEntity
    {
        public Category()
        {
            this.Posts = new HashSet<Post>();
        }
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Post> Posts { get; set; }    

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
