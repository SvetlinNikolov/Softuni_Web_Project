namespace SPN.Web.ViewModels.ForumViewModels.Post
{
    using SPN.Data.Common.Contracts;
    using SPN.Data.Models.Identity;
    using SPN.Web.ViewModels.ForumViewModels.Reply;
    using System;
    using System.Collections.Generic;

    public class PostIndexViewModel : IAuditInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }
        public int LikesCount { get; set; }
        public int Views { get; set; }
        public int RepliesCount { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public IEnumerable<PostReplyViewModel> Replies { get; set; }
    }
}
