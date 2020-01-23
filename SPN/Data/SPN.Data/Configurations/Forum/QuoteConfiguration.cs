namespace SPN.Data.Configurations.Forum
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
        }
    }
}
