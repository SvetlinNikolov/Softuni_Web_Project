namespace SPN.Web.ViewModels.Quote
{
    using SPN.Data.Common.Contracts;
    using System;
    public class ReplyQuoteViewModel : IAuditInfo
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public int LikesCount { get; set; }

        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }

        public int ReplyId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
