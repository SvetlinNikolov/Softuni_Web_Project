using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SPN.Auto.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Data.Configurations
{
    public class AutomobileConfiguration : IEntityTypeConfiguration<Automobile>
    {
        public void Configure(EntityTypeBuilder<Automobile> builder)
        {
            builder.HasKey(x => x.Id);

            //builder.HasOne(x => x.Make)
            //    .WithOne(y => y.Automobile)
            //    .HasForeignKey<Automobile>(z => z.MakeId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //builder.HasOne(x => x.Model)
            //    .WithMany(y => y.Make)
            // .HasForeignKey<Automobile>(z => z.ModelId)
            //    .OnDelete(DeleteBehavior.Restrict);

   
        }
    }
}
