namespace SPN.Services.Utilities
{
    using AutoMapper;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Web.InputModels.ForumInputModels.Post;
    using SPN.Web.ViewModels.ForumViewModels.Post;
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            this.CreateMap<Post, PostListingViewModel>()
          .ForMember(x => x.CategoryName, y => y.MapFrom(z => z.Category.Title))
          .ForMember(x => x.AuthorId, y => y.MapFrom(z => z.Author.UserName))
          .ForMember(x => x.CreatedOn, y => y.MapFrom(z => z.CreatedOn.ToString()))
          .ForMember(x => x.Title, y => y.MapFrom(z => z.Title))
           .ForMember(x => x.AuthorId, y => y.MapFrom(z => z.Author.Id))
          .ForMember(x => x.AuthorName, y => y.MapFrom(z => z.Author.UserName));

            this.CreateMap<Post, PostInputModel>()
                .ForMember(x => x.CategoryId, y => y.MapFrom(z => z.CategoryId))
                .ForMember(x => x.CategoryTitle, y => y.MapFrom(z => z.Category.Title))
                .ForMember(x => x.CategoryImageUrl, y => y.MapFrom(z => z.Category.ImageUrl));
            //.ForMember(x => x.AuthorId, y => y.MapFrom(z => z.AuthorId))
            //.ForMember(x => x.AuthorName, y => y.MapFrom(z => z.Author.UserName));


            this.CreateMap<PostInputModel, Post>()
                .ForMember(x => x.CategoryId, y => y.MapFrom(z => z.CategoryId))
                 .ForMember(x => x.Title, y => y.MapFrom(z => z.CategoryTitle));
            //.ForMember(x => x.Id, y => y.MapFrom(z => z.AuthorId));

            this.CreateMap<PostInputModel, Category>()
                  .ForMember(x => x.Id, y => y.MapFrom(z => z.CategoryId))
                .ForMember(x => x.Title, y => y.MapFrom(z => z.CategoryTitle))
                  .ForMember(x => x.ImageUrl, y => y.MapFrom(z => z.CategoryImageUrl));

            this.CreateMap<PostInputModel, User>();
            //  .ForMember(x => x.Id, y => y.MapFrom(z => z.AuthorId))
            //.ForMember(x => x.UserName, y => y.MapFrom(z => z.AuthorName));

            this.CreateMap<Post, PostIndexViewModel>()
                  .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                    .ForMember(x => x.Title, y => y.MapFrom(z => z.Title))
                      .ForMember(x => x.CategoryId, y => y.MapFrom(z => z.CategoryId))
                        .ForMember(x => x.AuthorId, y => y.MapFrom(z => z.AuthorId))
                          .ForMember(x => x.AuthorName, y => y.MapFrom(z => z.Author.UserName))//Maybe map it to user otdelno
                            .ForMember(x => x.AuthorImageUrl, y => y.MapFrom(z => z.Author.ProfileImage))
                            .ForMember(x => x.RepliesCount, y => y.MapFrom(z => z.Replies.Count))
                            .ForMember(x => x.Replies, y => y.MapFrom(z => z.Replies));



        }



    }
}
