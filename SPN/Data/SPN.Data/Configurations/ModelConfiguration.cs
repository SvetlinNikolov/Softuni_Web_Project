using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SPN.Auto.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Data.Configurations
{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasOne(x => x.Make)
                .WithMany(y => y.Models)
                .HasForeignKey(x => x.MakeId)
                .OnDelete(DeleteBehavior.Restrict);

       
        }
    }
}
