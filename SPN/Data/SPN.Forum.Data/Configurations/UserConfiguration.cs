namespace SPN.Forum.Data.Configurations
{

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SPN.Forum.Data.Models.Identity;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasMany(u => u.Posts)
                .WithOne(a => a.Author);

            builder.HasMany(u => u.Replies)
                .WithOne(r => r.Author);

            builder.HasMany(u => u.Quotes)
                .WithOne(r => r.Author);
           

            builder.HasMany(u => u.Contests)
                .WithOne(cc => cc.Author);

            builder.HasMany(u => u.ContestsSolutions)
                .WithOne(css => css.Author);

            
            //TODO Check if this config is enough

        }
    }
}
