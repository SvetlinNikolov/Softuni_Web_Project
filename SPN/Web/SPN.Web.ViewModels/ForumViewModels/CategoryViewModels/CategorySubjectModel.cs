namespace SPN.Web.ViewModels.ForumViewModels.CategoryViewModels
{
    using System.Collections.Generic;

    using SPN.Web.ViewModels.ForumViewModels.PostViewModels;

    public class CategorySubjectModel
    {
        public CategoryConciseViewModel Category { get; set; }
        public IEnumerable<PostListingViewModel> Posts { get; set; }
    }
}
