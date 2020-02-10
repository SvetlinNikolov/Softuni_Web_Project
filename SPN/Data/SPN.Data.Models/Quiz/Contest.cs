namespace SPN.Data.Models.Quiz
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
            ContestQuestions = new HashSet<ContestQuestion>();
            Participants = new HashSet<User>();
        }
        public string Title { get; set; }

        public int ContestCategoryId { get; set; }

        public virtual ContestCategory ContestCategory { get; set; }

        public string AuthorId { get; set; }

        public virtual User Author { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsPrivate { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public virtual ICollection<ContestQuestion> ContestQuestions { get; set; }

        public int QuestionsCount { get; set; }

        public virtual ICollection<User> Participants { get; set; }

        [NotMapped]
        public bool CanBeCompeted
        {
            get
            {
                if (IsPrivate)
                {
                    return false;
                }

                if (IsDeleted)
                {
                    return false;
                }

                if (!StartTime.HasValue)
                {
                    // Cannot be competed
                    return false;
                }

                if (!EndTime.HasValue)
                {
                    // Compete forever
                    return StartTime <= DateTime.UtcNow;
                }

                return StartTime <= DateTime.UtcNow && DateTime.UtcNow <= EndTime;
            }
        }
    }
}