namespace SPN.Web.InputModels.ForumInputModels.Category
{
    using Microsoft.AspNetCore.Http;
    using SPN.Forum.Data.Common.Constants;
    using System.ComponentModel.DataAnnotations;

    public class CategoryInputModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(ModelConstants.CategoryTitleMaxLength,
            MinimumLength = ModelConstants.CategoryTitleMinLength, ErrorMessage = ModelConstants.CategoryTitleLengthError)]
        public string Title { get; set; }

        [Required]
        [StringLength(ModelConstants.CategoryDescriptionMaxLength,
         MinimumLength = ModelConstants.CategoryDescriptionMinLength, ErrorMessage = ModelConstants.CategoryDescriptionLengthError)]
        public string Description { get; set; }

        [Display(Name ="Image URL")]
        public string ImageUrl { get; set; }

        [Display(Name = "Upload Image")]
        public IFormFile ImageUpload { get; set; }
    }
}
