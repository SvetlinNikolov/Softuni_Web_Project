using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Services.Contracts.Quiz
{
    public interface IContestQuestionService
    {
        public Task CreateContestQuestion(IFormCollection formCollection);
    }
}
