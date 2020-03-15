

namespace SPN.Quiz.Data.Configurations
{
    public class ContestCategoryConfiguration : IEntityTypeConfiguration<ContestCategory>
    {
        public void Configure(EntityTypeBuilder<ContestCategory> builder)
        {
            builder.HasKey(cc => cc.Id);

            builder.HasMany(category => category.Contests)
                .WithOne(contest => contest.ContestCategory)
                .HasForeignKey(category => category.ContestCategoryId)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
