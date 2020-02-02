namespace SPN.Web.InputModels.ForumInputModels.Post
{
    public class PostInputModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }
        public string CategoryImageUrl { get; set; }


    }
}
