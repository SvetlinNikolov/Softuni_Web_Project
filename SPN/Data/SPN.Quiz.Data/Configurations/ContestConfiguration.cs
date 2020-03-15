namespace SPN.Quiz.Data.Configurations
{


    public class ContestConfiguration : IEntityTypeConfiguration<Contest>
    {
        public void Configure(EntityTypeBuilder<Contest> builder)
        {
            builder
                .HasKey(contest => contest.Id);

            builder
             .HasOne(contest => contest.Author)
             .WithMany(user => user.Contests)
             .HasForeignKey(contest => contest.AuthorId)
             .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(contest => contest.ContestCategory)
                .WithMany(contestCategory => contestCategory.Contests)
                .HasForeignKey(contest => contest.ContestCategoryId);

            //builder.HasMany(contest => contest.ContestQuestions)
            //    .WithOne(contestQuestions => contestQuestions.Contest)
            //     .HasForeignKey(contestQuestion => contestQuestion.ContestId)
            //    .OnDelete(DeleteBehavior.Cascade);



        }
    }
}
