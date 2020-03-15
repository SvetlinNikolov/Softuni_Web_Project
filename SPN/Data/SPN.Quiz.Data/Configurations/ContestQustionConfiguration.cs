namespace SPN.Quiz.Data.Configurations
{


    class ContestQustionConfiguration : IEntityTypeConfiguration<ContestQuestion>
    {
        public void Configure(EntityTypeBuilder<ContestQuestion> builder)
        {
            builder.HasKey(c => new { c.Id });

            builder.HasOne(cq => cq.Contest)
                .WithMany(q => q.ContestQuestions)
                .HasForeignKey(cq => cq.Id); //TODO dont know about this one rick


        }
    }
}
