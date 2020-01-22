namespace Svetlinable.Data.Configurations.ForumConfigurations
{

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Svetlinable.Models.Forum;
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
        }
    }
}
