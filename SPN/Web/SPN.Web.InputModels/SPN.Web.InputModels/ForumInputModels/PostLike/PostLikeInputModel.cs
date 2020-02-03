namespace SPN.Web.InputModels.ForumInputModels.PostLike
{
    public class PostLikeInputModel
    {
        public int PostId { get; set; }

        public string PostAuthorId { get; set; }

        public int LikesCount { get; set; }

        public bool IsLiked { get; set; }
    }
}
