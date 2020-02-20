using System.ComponentModel.DataAnnotations;

namespace SPN.Web.InputModels.ForumInputModels.PostLike
{
    public class PostLikeInputModel
    {
        [Required]
        public int PostId { get; set; }

        [Required]
        public string LikeAuthor { get; set; }


    }
}
