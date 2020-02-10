namespace SPN.Data.Common.Models
{
    using System;

    using SPN.Data.Common.Contracts;
    public abstract class BaseDeletableEntity<TKey> : BaseEntity<TKey>, IDeletableEntity
    {
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}