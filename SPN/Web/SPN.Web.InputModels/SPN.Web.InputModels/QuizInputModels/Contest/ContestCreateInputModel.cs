using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Web.InputModels.QuizInputModels.Contest
{
    public class ContestCreateInputModel
    {
        public int Id { get; set; } //ContestCategoryId

        public string Title { get; set; }

        public string Description { get; set; }

        public int QuestionsCount { get; set; }

        public bool IsPrivate { get; set; }


    }
}
