using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SPN.Auto.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SPN.Forum.Data.Configurations.Auto
{
    public class MakeModelEntityConfiguration : IEntityTypeConfiguration<MakeModel>
    {
        public void Configure(EntityTypeBuilder<MakeModel> builder)
        {
            builder.HasKey(x => new { x.ModelId, x.MakeId });
        }
    }
}
