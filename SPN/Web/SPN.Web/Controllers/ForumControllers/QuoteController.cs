namespace SPN.Web.Controllers.ForumControllers
{
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    using SPN.Services.Contracts.Forum;
    using SPN.Services.Shared;
    using SPN.Web.InputModels.ForumInputModels.Quote;
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

        public async Task<IActionResult> Create(int replyId)
        {
            var replyContent = await this.replyService.GetReplyContent(replyId);

            var model = new QuoteInputModel
            {
                ReplyContent = replyContent

            };
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(QuoteInputModel model)
        {

            if (this.ModelState.IsValid)
            {
                await this.quoteService.CreateQuoteAsync(model);
                return this.Redirect($"/Post/Index?Id={model}");

            }
            else
            {
                return this.View(model);
            }
           
        }

    }
}
