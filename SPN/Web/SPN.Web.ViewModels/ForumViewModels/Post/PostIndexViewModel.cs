namespace SPN.Web.ViewModels.ForumViewModels.Post
{
    using System;
    using System.Collections.Generic;

    using SPN.Data.Common.Contracts;
    using SPN.Web.ViewModels.ForumViewModels.Reply;
    public class PostIndexViewModel : IAuditInfo
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }


        public string AuthorId { get; set; }

        public string AuthorName { get; set; }

        public string AuthorImageUrl { get; set; }

        public int CategoryId { get; set; }

        public string CategoryTitle { get; set; }

        public int LikesCount { get; set; }

        public int Views { get; set; }

        public int RepliesCount { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public IEnumerable<PostReplyViewModel> Replies { get; set; }
    }
}
