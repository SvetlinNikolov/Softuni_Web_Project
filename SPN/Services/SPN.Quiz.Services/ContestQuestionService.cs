using AutoMapper;
using Microsoft.AspNetCore.Http;
using SPN.Forum.Data;
using SPN.Services.Contracts.Quiz;
using SPN.Services.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Quiz.Services
{
    public class ContestQuestionService : BaseService, IContestQuestionService
    {
        public ContestQuestionService(IMapper mapper, SPNDbContext dbContext)
            : base(mapper, dbContext)
        {
        }

        public Task CreateContestQuestionAsync(IFormCollection formCollection)
        {
            var keys = formCollection.Keys;

            return null;
        }
    }
}
