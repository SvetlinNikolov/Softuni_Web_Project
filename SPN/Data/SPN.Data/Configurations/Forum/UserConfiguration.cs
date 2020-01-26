﻿namespace SPN.Data.Configurations.Forum
{

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SPN.Data.Models.Identity;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasMany(u => u.Posts)
                .WithOne(a => a.Author);

            builder.HasMany(u => u.Replies)
                .WithOne(r => r.Author);


            //TODO Check if this config is enough

        }
    }
}