using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SPN.Auto.Data.Models;

namespace SPN.Auto.Data.Configurations
{
    public class MakeModelEntityConfiguration : IEntityTypeConfiguration<MakeModel>
    {
        public void Configure(EntityTypeBuilder<MakeModel> builder)
        {
            builder.HasKey(x => new { x.ModelId, x.MakeId });
        }
    }
}
