namespace SPN.Data.Configurations.Forum
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SPN.Data.Models.Forum;

    public class ReplyConfiguration : IEntityTypeConfiguration<Reply>
    {
        public void Configure(EntityTypeBuilder<Reply> builder)
        {
            builder
                .HasKey(r => r.Id);

            builder
                .HasOne(r => r.Author)
                .WithMany(u => u.Replies)
                .HasForeignKey(r => r.AuthorId);

        


        }
    }
}
