using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SPN.Services.Contracts.Forum;
using SPN.Services.Shared;
using SPN.Web.InputModels.ForumInputModels.Quote;
using System.Net;
using System.Threading.Tasks;

namespace SPN.Web.Controllers.ForumControllers
{
    public class QuoteController : BaseController
    {
        private readonly IQuoteService quoteService;
        private readonly IReplyService replyService;

        public QuoteController(
            IUserService userService,
            IMapper mapper,
            IQuoteService quoteService,
            IReplyService replyService)
            : base(userService, mapper)
        {
            this.quoteService = quoteService;
            this.replyService = replyService;
        }

        public IActionResult Create()
        {
            return this.View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(QuoteInputModel model)
        {
            var reply = await this.replyService.GetReplyByIdAsync(model.ReplyId); //TODO Implement how the quotes would work
            var user = await this.userService.GetLoggedInUserAsync();

            model.ReplyContent = reply.Content;
            model.AuthorName = user.UserName;
            model.ReplyAuthorName = reply.Author.UserName;

            await this.quoteService.CreateQuoteAsync(model, user);

            return this.Redirect($"/Post/Index?Id={model.ReplyId}");


        }
    }
}
