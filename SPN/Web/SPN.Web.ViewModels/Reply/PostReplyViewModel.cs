namespace SPN.Web.ViewModels.ForumViewModels.Reply
{
    using System;
    using System.Collections.Generic;

    using SPN.Web.ViewModels.ForumViewModels.Quote;
    public class PostReplyViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }

        public int PostId { get; set; }

        public int LikesCount { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public IEnumerable<ReplyQuoteViewModel> Quotes { get; set; }
    }
}
