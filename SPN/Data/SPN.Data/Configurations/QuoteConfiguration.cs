namespace SPN.Forum.Data.Configurations
{

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SPN.Data.Models.Forum;

    public class QuoteConfiguration : IEntityTypeConfiguration<Quote>
    {
        public void Configure(EntityTypeBuilder<Quote> builder)
        {
            builder
             .HasKey(r => r.Id);

            builder
                .HasOne(r => r.Author)
                .WithMany(u => u.Quotes)
                .HasForeignKey(r => r.AuthorId);

            builder
             .HasOne(q => q.Reply)
             .WithMany(r => r.Quotes)
             .HasForeignKey(q => q.ReplyId)
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
