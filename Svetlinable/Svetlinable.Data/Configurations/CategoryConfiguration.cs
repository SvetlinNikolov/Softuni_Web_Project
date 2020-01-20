namespace Svetlinable.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Svetlinable.Models.Forum;
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                 .HasKey(c => c.Id);

            builder
                .HasMany(c => c.Posts)
                .WithOne(f => f.Category)
                .HasForeignKey(f => f.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
