namespace SPN.Web.ViewModels.ForumInputModels.Category
{
    using Microsoft.AspNetCore.Http;
    using SPN.Web.ViewModels.ForumInputModels.Contracts;

    public class CategoryInputModel : ICategoryInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public IFormFile ImageUpload { get; set; }
    }
}
