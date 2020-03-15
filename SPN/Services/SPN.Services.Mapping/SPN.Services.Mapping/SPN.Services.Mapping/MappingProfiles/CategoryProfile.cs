namespace SPN.Forum.Services.Mapping.MappingProfiles
{
    using AutoMapper;

    using SPN.Forum.Data.Models.Forum;
    using SPN.Web.InputModels.ForumInputModels.Category;
    using SPN.Web.ViewModels.ForumViewModels.CategoryViewModels;
    using System;

    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryInputModel, Category>()
                .ForMember(x => x.CreatedOn, y => y.MapFrom(z => DateTime.UtcNow));

            CreateMap<Category, CategoryConciseViewModel>()
                .ForMember(x => x.PostsCount, y => y.MapFrom(z => z.Posts.Count));

        }

    }
}
