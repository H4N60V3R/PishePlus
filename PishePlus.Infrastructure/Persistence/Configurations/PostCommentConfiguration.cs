using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class PostCommentConfiguration : IEntityTypeConfiguration<PostComment>
    {
        public void Configure(EntityTypeBuilder<PostComment> entity)
        {
            entity.HasIndex(e => e.CommentId);

            entity.HasIndex(e => e.PostId);

            entity.Property(e => e.PostCommentId).HasColumnName("PostCommentID");

            entity.Property(e => e.CommentId).HasColumnName("CommentID");

            entity.Property(e => e.IsAccept).HasDefaultValueSql("((1))");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PostCommentGuid)
                .HasColumnName("PostCommentGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.PostId).HasColumnName("PostID");

            entity.HasOne(d => d.Comment)
                .WithMany(p => p.PostComment)
                .HasForeignKey(d => d.CommentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PostComment_Comment");

            entity.HasOne(d => d.Post)
                .WithMany(p => p.PostComment)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PostComment_Post");
        }
    }
}
