namespace SPN.Web.ViewModels.ForumViewModels.Post
{
    using SPN.Web.ViewModels.ForumViewModels.CategoryViewModels;

    public class PostListingViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string AuthorId { get; set; }
        public int LikesCount { get; set; } //TODO IMPLEMENT HOW THE LIKES SHOULD WORK
        public int RepliesCount { get; set; }
        public string CreatedOn { get; set; }
        public string PostImageUrl { get; set; }
        public string CategoryName { get; set; }
        public CategoryConciseViewModel Category { get; set; }
    }
}
