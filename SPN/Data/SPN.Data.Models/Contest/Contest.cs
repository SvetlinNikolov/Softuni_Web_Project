namespace SPN.Data.Models.Contest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using SPN.Data.Common.Contracts;
    using SPN.Data.Common.Models;
    using SPN.Data.Models.Identity;

    public class Contest : BaseEntity<int>, IDeletableEntity
    {
        public Contest()
        {
            this.ContestQuestions = new HashSet<ContestQuestion>();
            this.Participants = new HashSet<User>();
        }
        public int CategoryId { get; set; }

        public string AuthorId { get; set; }

        public User Author { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ContestPassword { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsPrivate { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public ICollection<ContestQuestion> ContestQuestions { get; set; }

        public ICollection<User> Participants { get; set; }

        [NotMapped]
        public bool CanBeCompeted
        {
            get
            {
                if (this.IsPrivate)
                {
                    return false;
                }

                if (this.IsDeleted)
                {
                    return false;
                }

                if (!this.StartTime.HasValue)
                {
                    // Cannot be competed
                    return false;
                }

                if (!this.EndTime.HasValue)
                {
                    // Compete forever
                    return this.StartTime <= DateTime.UtcNow;
                }

                return this.StartTime <= DateTime.UtcNow && DateTime.UtcNow <= this.EndTime;
            }
        }
    }
}