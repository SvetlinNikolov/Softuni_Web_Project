namespace SPN.Web.ViewModels.ForumViewModels.CategoryViewModels
{
    using System.Collections.Generic;
    using SPN.Web.ViewModels.ForumViewModels.Post;

    public class CategoryTopicModel
    {
        public CategoryConciseViewModel Category { get; set; }

        public IEnumerable<PostListingViewModel> Posts { get; set; }
    }
}
