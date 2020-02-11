
namespace SPN.Data.Models.Quiz
{
    using System.Collections.Generic;

    using SPN.Data.Models.Identity;

    public class ContestSolution
    {
        public ContestSolution()
        {
            this.ContestQuestionAnswers = new HashSet<ContestQuestionAnswer>();
        }
        public int Id { get; set; }

        public int ContestId { get; set; }

        public Contest Contest { get; set; }

        public User Author { get; set; }

        public string AuthorId { get; set; }

        public virtual ICollection<ContestQuestionAnswer> ContestQuestionAnswers { get; set; }

       
    }
}
