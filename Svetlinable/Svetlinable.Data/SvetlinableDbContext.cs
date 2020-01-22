namespace Svetlinable.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using System.Reflection;

    using Svetlinable.Models.Shared;
    using Svetlinable.Models.Forum;

    public class SvetlinableDbContext:IdentityDbContext<User>
    {
        public SvetlinableDbContext(DbContextOptions<SvetlinableDbContext> options)
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
