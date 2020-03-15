using System.Reflection;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
using SPN.Data.Common.Identity;
using SPN.Forum.Data.Models;
using SPN.Quiz.Data.Models;

namespace SPN.Data
{
  
    public class SPNDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public SPNDbContext(DbContextOptions options)
            : base(options)
        {
        }

     
        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<PostLike> PostLikes { get; set; }

        public DbSet<Reply> Replies { get; set; }

        public DbSet<ReplyLike> ReplyLikes { get; set; }

        public DbSet<Quote> Quotes { get; set; }

        public DbSet<QuoteLike> QuoteLikes { get; set; }



        public DbSet<ContestCategory> ContestCategories { get; set; }

        public DbSet<Contest> Contests { get; set; }

        public DbSet<ContestQuestion> ContestQuestions { get; set; }

        public DbSet<ContestSolution> ContestSolutions { get; set; }

        public DbSet<ContestQuestionAnswer> ContestQuestionAnswers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
