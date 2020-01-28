using SPN.Data.Models.Forum;
using System.Threading.Tasks;

namespace SPN.Services.Contracts.Forum
{
   public interface IReplyService
    {
        Task AddReply(Reply reply);
        Task DeleteReply(Reply reply);
        Reply GetReplyById(int id);
        Task EditReply(int replyId, string newMessage);
    }
}
