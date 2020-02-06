namespace SPN.Services.Mapping
{
    using AutoMapper;

    using SPN.Data.Models.Forum;
    using SPN.Web.InputModels.ForumInputModels.Category;
    using SPN.Web.ViewModels.ForumViewModels.CategoryViewModels;
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<CategoryInputModel, Category>();

            this.CreateMap<Category, CategoryConciseViewModel>();
        }

    }
}
