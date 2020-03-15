using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SPN.Data;
using SPN.Data.Models.Quiz;
using SPN.Services.Contracts.Quiz;
using SPN.Services.Shared;
using SPN.Web.InputModels.QuizInputModels.Contest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Services.QuizServices
{
    public class ContestService : BaseService, IContestService
    {
        private readonly IUserService userService;

        public ContestService(IMapper mapper, SPNDbContext dbContext, IUserService userService)
            : base(mapper, dbContext)
        {
            this.userService = userService;
        }

        public async Task CreateContestAsync(ContestCreateInputModel model)
        {
            var user = await this.userService.GetLoggedInUserAsync();

            var contestCategory = await this.dbContext.ContestCategories
                .FirstOrDefaultAsync(cc => cc.Id == model.Id);

            var contest = new Contest
            {
                Title = model.Title,
                Description = model.Description,
                CreatedOn = DateTime.UtcNow,
                QuestionsCount = model.QuestionsCount,
                ContestCategoryId = contestCategory.Id,
                AuthorId = user.Id

            };

      
          
            var questions = new List<ContestQuestion>(); //TODO this a job for contestQuestion service

            for (int i = 0; i < model.QuestionsCount; i++)
            {
                questions.Add(new ContestQuestion { ContestId = contest.Id });

            }

            await this.dbContext.Contests.AddAsync(contest);
            await this.dbContext.ContestQuestions.AddRangeAsync(questions);

            await this.dbContext.SaveChangesAsync();

        }
    }
}
