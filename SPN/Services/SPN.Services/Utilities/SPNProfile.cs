namespace SPN.Services.Utilities
{
    using AutoMapper;
    using SPN.Data.Models.Forum;
    using SPN.Web.ViewModels.ForumInputModels.Category;
    using SPN.Web.ViewModels.ForumViewModels.CategoryViewModels;
    using SPN.Web.ViewModels.ForumViewModels.Post;
    using System.Collections.Generic;

    public class SPNProfile : Profile
    {
        public SPNProfile()
        {
            this.CreateMap<CategoryInputModel, Category>();

            this.CreateMap<Category, CategoryConciseViewModel>();

            this.CreateMap<Post, PostListingViewModel>()
                .ForMember(x => x.CategoryName, y => y.MapFrom(z => z.Category.Title))
                .ForMember(x => x.AuthorId, y => y.MapFrom(z => z.Author.UserName))
                .ForMember(x => x.CreatedOn, y => y.MapFrom(z => z.CreatedOn.ToString()))
                .ForMember(x => x.Title, y => y.MapFrom(z => z.Title))
                 .ForMember(x => x.AuthorId, y => y.MapFrom(z => z.Author.Id))
                .ForMember(x => x.AuthorName, y => y.MapFrom(z => z.Author.UserName));

        }

    }
}
