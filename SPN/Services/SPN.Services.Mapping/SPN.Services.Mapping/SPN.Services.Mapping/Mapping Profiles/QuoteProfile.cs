using AutoMapper;
using SPN.Forum.Data.Models;
using SPN.Forum.Web.InputModels.Quote;

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
