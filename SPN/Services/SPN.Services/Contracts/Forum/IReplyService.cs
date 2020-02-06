namespace SPN.Services.Contracts.Forum
{
    using System.Threading.Tasks;

    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Web.InputModels.ForumInputModels.Reply;
 
    public interface IReplyService
    {
        Task<int> CreateReplyAsync(ReplyInputModel reply,User user);
        Task<int> DeleteReplyAsync(int id);
        Task<Reply> GetReplyByIdAsync(int id);
        Task<Reply> EditReplyAsync(int replyId, string newMessage);
    }
}
