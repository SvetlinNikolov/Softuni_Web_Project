namespace SPN.Web.ViewModels.ForumInputModels.Post
{
    public class PostInputModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImageUrl { get; set; }

        public string AuthorId { get; set; }
        public string AuthorName { get; set; }


    }
}
