namespace SPN.Data.Models.Quiz
{
    using System;

    using SPN.Data.Common.Contracts;

    public class ContestQuestionAnswer : IDeletableEntity
    {
        public int Id { get; set; }

        public int ContestQuestionId { get; set; }

        public virtual ContestQuestion ContestQuestion { get; set; }

        public bool IsCorrect { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
