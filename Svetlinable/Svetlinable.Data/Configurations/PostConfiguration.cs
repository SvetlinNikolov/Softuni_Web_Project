﻿namespace Svetlinable.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using Svetlinable.Models.Forum;

    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder
                 .HasKey(c => c.Id);

            builder
                .HasOne(p => p.Author)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(p => p.Category)
                .WithMany(f => f.Posts)
                .HasForeignKey(p => p.CategoryId);


            //builder
            //    .HasMany(p => p.Replies)
            //    .WithOne(f => f.Post)
            //    .HasForeignKey(p => p.PostId)
            //    .OnDelete(DeleteBehavior.Cascade);
               

            builder.HasMany(p => p.PostLikes)
                .WithOne(ps => ps.Post)
                .OnDelete(DeleteBehavior.Cascade);
          


        }
    }
}
