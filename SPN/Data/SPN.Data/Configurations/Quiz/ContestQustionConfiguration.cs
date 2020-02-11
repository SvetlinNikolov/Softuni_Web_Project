namespace SPN.Data.Configurations.Quiz
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using SPN.Data.Models.Quiz;
 
    class ContestQustionConfiguration : IEntityTypeConfiguration<ContestQuestion>
    {
        public void Configure(EntityTypeBuilder<ContestQuestion> builder)
        {
            builder.HasKey(cq => cq.Id);

            builder.HasOne(cq => cq.Contest)
                .WithMany(q => q.ContestQuestions)
                .HasForeignKey(cq => cq.Id); //TODO dont know about this one rick

         
        }
    }
}
