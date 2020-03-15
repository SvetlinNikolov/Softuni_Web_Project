namespace SPN.Quiz.Data.Models
{
    using System;
    using System.Collections.Generic;
    using SPN.Forum.Data.Common.Contracts;
    using SPN.Quiz.Data.Models.Enums;

    public class ContestQuestion : IDeletableEntity
    {
        public ContestQuestion()
        {
            ContestQuestionAnswers = new HashSet<ContestQuestionAnswer>();
        }
        public int Id { get; set; }

        public int ContestId { get; set; }

        public virtual Contest Contest { get; set; }

        public string Description { get; set; }

        public ContestQuestionType QuestionType { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<ContestQuestionAnswer> ContestQuestionAnswers { get; set; }
    }
}
