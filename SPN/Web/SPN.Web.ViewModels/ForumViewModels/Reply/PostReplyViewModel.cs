namespace SPN.Web.ViewModels.ForumViewModels.Reply
{
    using SPN.Data.Models.Identity;
    using SPN.Web.ViewModels.ForumViewModels.Quote;
    using System;
    using System.Collections.Generic;

    public class PostReplyViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }

        public int PostId { get; set; }

        //public string CategoryName { get; set; }
        //public string CategoryImageUrl { get; set; }
        //public int CategoryId { get; set; }

        public int LikesCount { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public IEnumerable<ReplyQuoteViewModel> Quotes { get; set; }
    }
}
