using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SPN.Auto.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Data.Configurations
{
    public class MakeConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            //builder.HasOne(a => a.Automobile)
            //         .WithOne(b => b.Id)
            //         .HasForeignKey<Make>(b => b.AutomobileId)
            //         .OnDelete(DeleteBehavior.Restrict);

           
        }
    }
}
