using AutoMapper;
using SPN.Data.Models.Forum;
using SPN.Web.InputModels.ForumInputModels.Quote;

namespace SPN.Services.Mapping.Mapping_Profiles
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
