namespace SPN.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Identity;
    using System.Reflection;
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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
