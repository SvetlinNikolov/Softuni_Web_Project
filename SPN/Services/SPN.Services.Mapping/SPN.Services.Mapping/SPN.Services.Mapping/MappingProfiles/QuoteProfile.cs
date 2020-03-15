using AutoMapper;
using SPN.Forum.Data.Models.Forum;
using SPN.Web.InputModels.ForumInputModels.Quote;

namespace SPN.Forum.Services.Mapping.MappingProfiles
{
    public class QuoteProfile : Profile
    {
        public QuoteProfile()
        {
            this.CreateMap<QuoteInputModel, Quote>()
                .ForMember(x => x.ReplyId, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.AuthorId, y => y.MapFrom(z => z.AuthorId));


        }
    }
}
