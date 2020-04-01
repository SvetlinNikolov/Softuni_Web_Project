namespace SPN.Forum.Services.Contracts
{
    using System.Threading.Tasks;
    using SPN.Forum.Data.Models;
    using SPN.Forum.Data.Models.Identity;
    using SPN.Forum.Web.InputModels.Reply;

    public interface IReplyService
    {
        Task CreateReplyAsync(ReplyInputModel reply, User user);

        Task DeleteReplyAsync(int id);

        Task<Reply> GetReplyByIdAsync(int id);

        Task<Reply> EditReplyAsync(int replyId, string newMessage);

        Task<string> GetReplyContent(int replyId);
    }
}
