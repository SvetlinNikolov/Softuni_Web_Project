namespace SPN.Web.ViewModels.ForumInputModels.Contracts
{
    using Microsoft.AspNetCore.Http;
    public interface ICategoryInputModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public IFormFile ImageUpload { get; set; }
    }
}
