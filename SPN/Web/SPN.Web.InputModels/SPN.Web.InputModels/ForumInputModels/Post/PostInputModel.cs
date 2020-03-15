using SPN.Forum.Data.Common.Constants;
using System.ComponentModel.DataAnnotations;

namespace SPN.Web.InputModels.ForumInputModels.Post
{
    public class PostInputModel
    {
        public int Id { get; set; } //was categoryId

        [Required]
        [StringLength(ModelConstants.PostTitleMaxLength,
            MinimumLength = ModelConstants.PostTitleMinLength, ErrorMessage = ModelConstants.PostTitleLengthError)]
        public string Title { get; set; }

        [Required]
        [StringLength(ModelConstants.PostContentMaxLength,
            MinimumLength = ModelConstants.PostContentMinLength, ErrorMessage = ModelConstants.PostContentLengthError)]
        public string Content { get; set; }

        public string CategoryTitle { get; set; } 

        public string CategoryImageUrl { get; set; }


    }
}
