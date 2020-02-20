namespace SPN.Web.InputModels.ForumInputModels.Reply
{
    using System.ComponentModel.DataAnnotations;

    using SPN.Data.Common.Constants;
   

    public class ReplyInputModel
    {
        public int Id { get; set; } //Id of the post we are replying to

        [Required]
        [StringLength(ModelConstants.ReplyContentMaxLenght,
            MinimumLength = ModelConstants.ReplyContentMinLenght, ErrorMessage = ModelConstants.ReplyContentLengthError)]
        public string Content { get; set; }
    }
}
