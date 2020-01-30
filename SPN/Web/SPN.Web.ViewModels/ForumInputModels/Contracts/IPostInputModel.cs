namespace SPN.Web.ViewModels.ForumInputModels.Contracts
{
   public interface IPostInputModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
