namespace SPN.Services.Mapping.Mapping_Profiles
{
    using AutoMapper;

    using SPN.Data.Models.Quiz;
    using SPN.Web.InputModels.QuizInputModels;
    using SPN.Web.ViewModels.QuizViewModels.ContestCategory;
    using System;

    public class ContestCategoryProfile : Profile
    {
        public ContestCategoryProfile()
        {
            this.CreateMap<ContestCategoryInputModel, ContestCategory>()
                .ForMember(x => x.CreatedOn, y => y.MapFrom(z => DateTime.UtcNow));

            this.CreateMap<ContestCategory, ContestCategoryConciseViewModel>();
        }
    }
}
