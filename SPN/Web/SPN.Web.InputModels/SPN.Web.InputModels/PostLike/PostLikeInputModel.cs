using System.ComponentModel.DataAnnotations;

namespace SPN.Forum.Web.InputModels.PostLike
{
    public class PostLikeInputModel
    {
        [Required]
        public int PostId { get; set; }

        [Required]
        public string LikeAuthor { get; set; }


    }
}
