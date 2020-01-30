namespace SPN.Web.ViewModels.ForumInputModels.Category
{
    using Microsoft.AspNetCore.Http;
    using SPN.Services.Mapping.Contracts;
    using SPN.Web.ViewModels.ForumInputModels.Contracts;

    public class CategoryInputModel : ICategoryInputModel,IMapTo<Data.Models.Forum.Category>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageUpload { get; set; }
    }
}
