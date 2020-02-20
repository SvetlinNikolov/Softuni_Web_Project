namespace SPN.Web.InputModels.ForumInputModels.Category
{
    using Microsoft.AspNetCore.Http;
    using SPN.Data.Common.Constants;
    using System.ComponentModel.DataAnnotations;

    public class CategoryInputModel
    {
        [Required]
        [StringLength(ModelConstants.CategoryTitleMaxLength,
            MinimumLength = ModelConstants.CategoryTitleMinLength, ErrorMessage = ModelConstants.CategoryTitleLengthError)]
        public string Title { get; set; }

        [Required]
        [StringLength(ModelConstants.CategoryDescriptionMaxLength,
         MinimumLength = ModelConstants.CategoryDescriptionMinLength, ErrorMessage = ModelConstants.CategoryDescriptionLengthError)]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public IFormFile ImageUpload { get; set; }
    }
}
