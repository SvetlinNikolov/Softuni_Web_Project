namespace SPN.Data.Models.Contest
{
    using System;

    using SPN.Data.Common.Contracts;
    using SPN.Data.Common.Models;

    public class ContestQuestion :IDeletableEntity
    {
        public int Id { get; set; }

        public int ContestId { get; set; }

        public Contest Contest { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
