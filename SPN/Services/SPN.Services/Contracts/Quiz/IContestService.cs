using SPN.Web.InputModels.QuizInputModels.Contest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SPN.Services.Contracts.Quiz
{
    public interface IContestService
    {
        public Task CreateContestAsync(ContestCreateInputModel inputModel);

    }
}
