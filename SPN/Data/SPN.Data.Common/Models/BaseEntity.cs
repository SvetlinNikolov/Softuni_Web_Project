namespace SPN.Data.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using SPN.Data.Common.Contracts;
    public class BaseEntity<TKey> : IAuditInfo
    {
        [Key]
        public TKey Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
