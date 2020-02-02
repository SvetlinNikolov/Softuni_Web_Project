namespace SPN.Web.InputModels.ForumInputModels.Category
{
    using Microsoft.AspNetCore.Http;

    public class CategoryInputModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageUpload { get; set; }
    }
}
