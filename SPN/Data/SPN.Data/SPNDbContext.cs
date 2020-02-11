namespace SPN.Data
{
    using System.Reflection;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using SPN.Data.Models.Quiz;

    public class SPNDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public SPNDbContext(DbContextOptions<SPNDbContext> options)
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
