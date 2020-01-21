namespace Svetlinable.Web.ViewModels.CategoryViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class CategoryListingViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int LikesCount { get; set; }         //TODO IMPLEMENT HOW THE LIKES SHOULD WORK
    }
}
