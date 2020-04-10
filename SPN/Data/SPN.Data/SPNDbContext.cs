namespace SPN.Forum.Data
{
    using System.Reflection;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using SPN.Auto.Data.Configurations;
    using SPN.Auto.Data.Models;
    using SPN.Forum.Data.Models;
    using SPN.Forum.Data.Models.Identity;

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

        public DbSet<Make> Makes { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<MakeModel> MakesModels { get; set; }

        public DbSet<Automobile> Automobiles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
  
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
