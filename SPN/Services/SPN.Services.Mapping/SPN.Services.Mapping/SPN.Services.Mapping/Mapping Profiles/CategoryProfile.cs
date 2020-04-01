namespace SPN.Services.Mapping
{
    using AutoMapper;
    using SPN.Forum.Data.Models;
    using SPN.Forum.Web.InputModels.Category;
    using SPN.Web.ViewModels.ForumViewModels.CategoryViewModels;
    using System;

    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<CategoryInputModel, Category>()
                .ForMember(x => x.CreatedOn, y => y.MapFrom(z => DateTime.UtcNow));

            this.CreateMap<Category, CategoryConciseViewModel>()
                .ForMember(x => x.PostsCount, y => y.MapFrom(z => z.Posts.Count));
                
        }

    }
}
