namespace SPN.Forum.Services.Mapping.MappingProfiles.MappingProfiles
{
    using AutoMapper;

    using SPN.Quiz.Data.Models;
    using SPN.Web.InputModels.QuizInputModels.ContestCategory;
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
