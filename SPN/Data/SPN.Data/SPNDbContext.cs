namespace SPN.Forum.Data
{
    using System.Reflection;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
 
    using SPN.Data.Models.Auto;
    using SPN.Data.Models.Forum;
    using SPN.Data.Models.Shared.Identity;

    public class SPNDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public SPNDbContext(DbContextOptions<SPNDbContext> options)
          : base(options)
        {

        }

        //Forum
        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<PostLike> PostLikes { get; set; }

        public DbSet<Reply> Replies { get; set; }

        public DbSet<ReplyLike> ReplyLikes { get; set; }

        public DbSet<Quote> Quotes { get; set; }

        public DbSet<QuoteLike> QuoteLikes { get; set; }

        //Auto

        public DbSet<Make> Makes { get; set; }

        public DbSet<Model> Models { get; set; }

        public DbSet<Automobile> Automobiles { get; set; }

        public DbSet<PrimaryProperties> PrimaryProperties { get; set; }
     
        public DbSet<Safety> SafetyFeatures { get; set; }

        public DbSet<Interiors> Interiors { get; set; }

        public DbSet<InteriorMaterials> InteriorMaterials { get; set; }

        public DbSet<Suspensions> Suspensions { get; set; }

        public DbSet<SpecializedFeatures> SpecializedFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
