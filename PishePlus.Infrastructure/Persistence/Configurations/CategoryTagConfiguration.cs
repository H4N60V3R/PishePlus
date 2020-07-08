using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class CategoryTagConfiguration : IEntityTypeConfiguration<CategoryTag>
    {
        public void Configure(EntityTypeBuilder<CategoryTag> entity)
        {
            entity.HasIndex(e => e.CategoryId);

            entity.HasIndex(e => e.TagId);

            entity.Property(e => e.CategoryTagId).HasColumnName("CategoryTagID");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

            entity.Property(e => e.CategoryTagGuid)
                .HasColumnName("CategoryTagGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.TagId).HasColumnName("TagID");

            entity.HasOne(d => d.Category)
                .WithMany(p => p.CategoryTag)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CategoryTag_Category");

            entity.HasOne(d => d.Tag)
                .WithMany(p => p.CategoryTag)
                .HasForeignKey(d => d.TagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CategoryTag_Tag");
        }
    }
}
