namespace SPN.Data.Models.Contest
{
    using System;

    using SPN.Data.Common.Contracts;
    using SPN.Data.Models.Contest.Enums;

    public class ContestQuestion : IDeletableEntity
    {
        public int Id { get; set; }

        public int ContestId { get; set; }

        public virtual Contest Contest { get; set; }

        public string Description { get; set; }

        public ContestQuestionType QuestionType { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
