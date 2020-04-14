namespace SPN.Services.Mapping
{
    using AutoMapper;
    using SPN.Data.Models.Forum;
    using SPN.Forum.Web.InputModels.Post;
    using SPN.Web.ViewModels.ForumViewModels.Post;
    using SPN.Web.ViewModels.ForumViewModels.Reply;

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
                .ForMember(x => x.Id, y => y.MapFrom(z => z.CategoryId))
                .ForMember(x => x.CategoryTitle, y => y.MapFrom(z => z.Category.Title))
                .ForMember(x => x.CategoryImageUrl, y => y.MapFrom(z => z.Category.ImageUrl));


            this.CreateMap<PostInputModel, Post>()
                .ForMember(x => x.CategoryId, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Title, y => y.MapFrom(z => z.CategoryTitle))
                .ForMember(x => x.Content, y => y.MapFrom(z => z.Content));


            this.CreateMap<PostInputModel, Category>()
                  .ForMember(x => x.Id, y => y.MapFrom(z => z.Id));

            this.CreateMap<Reply, PostReplyViewModel>()
               .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
               .ForMember(x => x.AuthorId, y => y.MapFrom(z => z.AuthorId))
               .ForMember(x => x.AuthorName, y => y.MapFrom(z => z.Author.UserName))
               .ForMember(x => x.AuthorImageUrl, y => y.MapFrom(z => z.Author.ProfileImage))
               .ForMember(x => x.PostId, y => y.MapFrom(z => z.PostId))
               .ForMember(x => x.LikesCount, y => y.MapFrom(z => z.ReplyLikes.Count));//TODO Need to set up quotes for later

            this.CreateMap<Post, PostIndexViewModel>()
                  .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                  .ForMember(x => x.Title, y => y.MapFrom(z => z.Title))
                  .ForMember(x => x.CategoryId, y => y.MapFrom(z => z.CategoryId))
                  .ForMember(x => x.AuthorId, y => y.MapFrom(z => z.AuthorId))
                  .ForMember(x => x.AuthorName, y => y.MapFrom(z => z.Author.UserName))
                  .ForMember(x => x.AuthorImageUrl, y => y.MapFrom(z => z.Author.ProfileImage))
                  .ForMember(x => x.RepliesCount, y => y.MapFrom(z => z.Replies.Count))
                  .ForMember(x => x.Replies, y => y.MapFrom(z => z.Replies));
        }
    }
}
