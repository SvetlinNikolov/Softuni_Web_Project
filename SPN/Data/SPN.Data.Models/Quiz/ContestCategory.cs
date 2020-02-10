namespace SPN.Data.Models.Quiz
{
    using System;
    using System.Collections.Generic;

    using SPN.Data.Common.Contracts;
    using SPN.Data.Common.Models;

    public class ContestCategory : BaseEntity<int>, IDeletableEntity
    {
        public ContestCategory()
        {
            Contests = new HashSet<Contest>();
        }
        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsPrivate { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<Contest> Contests { get; set; }

    }
}
