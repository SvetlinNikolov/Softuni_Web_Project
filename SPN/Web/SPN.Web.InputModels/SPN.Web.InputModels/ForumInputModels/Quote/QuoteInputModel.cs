namespace SPN.Web.InputModels.ForumInputModels.Quote
{
    using System.ComponentModel.DataAnnotations;

    using SPN.Data.Common.Constants;
    public class QuoteInputModel
    {
        
        public int Id { get; set; }

        [Required]
        public string ReplyAuthorId { get; set; }

        [Required]
        public string ReplyAuthorName { get; set; }

        [Required]
        public string ReplyContent { get; set; }         //The reply we are quoting (the actual text)

        [Required]
        public string AuthorId { get; set; }


        [Required]
        [StringLength(ModelConstants.QuoteContentMaxLenght,
            MinimumLength = ModelConstants.QuoteContentMinLenght, ErrorMessage = ModelConstants.QuoteContentLenghtError)]
        public string Content { get; set; }


    }
}
