namespace SPN.Data.Models.Quiz
{
    using System;
    using System.Collections.Generic;

    using SPN.Data.Common.Contracts;
    using SPN.Data.Models.Quiz.Enums;

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
