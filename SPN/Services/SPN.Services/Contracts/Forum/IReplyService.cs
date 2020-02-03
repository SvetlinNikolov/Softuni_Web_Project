namespace SPN.Services.Contracts.Forum
{
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Web.InputModels.ForumInputModels.Reply;
    using System.Threading.Tasks;

    public interface IReplyService
    {
        Task<int> AddReplyAsync(ReplyInputModel reply, User user);
        Task<Reply> DeleteReplyAsync(Reply reply);
        Task<Reply> GetReplyByIdAsync(int id);
        Task<Reply> EditReplyAsync(int replyId, string newMessage);
    }
}
