namespace SPN.Services.Utilities
{
    using AutoMapper;
    using SPN.Data.Models.Forum;
    using SPN.Web.ViewModels.ForumInputModels.Category;
    using SPN.Web.ViewModels.ForumInputModels.Post;
    using SPN.Web.ViewModels.ForumViewModels.CategoryViewModels;
    using SPN.Web.ViewModels.ForumViewModels.Post;
    using System.Collections.Generic;

    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<CategoryInputModel, Category>();

            this.CreateMap<Category, CategoryConciseViewModel>();
        }

    }
}
