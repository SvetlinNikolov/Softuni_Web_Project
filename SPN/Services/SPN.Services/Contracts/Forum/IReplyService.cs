namespace SPN.Services.Contracts.Forum
{
    using System.Threading.Tasks;

    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Web.InputModels.ForumInputModels.Reply;
 
    public interface IReplyService
    {
        Task CreateReplyAsync(ReplyInputModel reply,User user);

        Task DeleteReplyAsync(int id);

        Task<Reply> GetReplyByIdAsync(int id);

        Task<Reply> EditReplyAsync(int replyId, string newMessage);

        Task <string>GetReplyContent(int replyId);
    }
}
