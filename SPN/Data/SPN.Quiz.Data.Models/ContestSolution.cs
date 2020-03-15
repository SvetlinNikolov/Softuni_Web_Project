using SPN.Quiz.Data.Models;

namespace SPN.Quiz.Data.Models
{
    using System.Collections.Generic;



    public class ContestSolution
    {
        public ContestSolution()
        {
            ContestQuestionAnswers = new HashSet<ContestQuestionAnswer>();
        }
        public int Id { get; set; }

        public int ContestId { get; set; }

        public Contest Contest { get; set; }

        public User Author { get; set; }

        public string AuthorId { get; set; }

        public virtual ICollection<ContestQuestionAnswer> ContestQuestionAnswers { get; set; }


    }
}
