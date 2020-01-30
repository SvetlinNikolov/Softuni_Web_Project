namespace SPN.Web.ViewModels.ForumInputModels.Contracts
{
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;

    public interface ICategoryInputModel
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public IFormFile ImageUpload { get; set; }
    }
}
