namespace SPN.Forum.Data.Configurations
{

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SPN.Data.Models.Shared.Identity;

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

            builder.HasMany(a => a.Automobiles)
                .WithOne(u => u.User)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);



            //TODO Check if this config is enough

        }
    }
}
