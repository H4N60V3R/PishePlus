using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.HasIndex(e => e.ActiveIconDocumentId);

            entity.HasIndex(e => e.CoverDocumentId);

            entity.HasIndex(e => e.SecondPageCoverDocumentId);

            entity.HasIndex(e => e.InactiveIconDocumentId);

            entity.HasIndex(e => e.ParentCategoryId);

            entity.HasIndex(e => e.QuadMenuDocumentId);

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

            entity.Property(e => e.ActiveIconDocumentId).HasColumnName("ActiveIconDocumentID");

            entity.Property(e => e.CategoryGuid)
                .HasColumnName("CategoryGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.CoverDocumentId).HasColumnName("CoverDocumentID");

            entity.Property(e => e.DisplayName)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.InactiveIconDocumentId).HasColumnName("InactiveIconDocumentID");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ParentCategoryId).HasColumnName("ParentCategoryID");

            entity.Property(e => e.QuadMenuDocumentId).HasColumnName("QuadMenuDocumentID");

            entity.Property(e => e.SecondPageCoverDocumentId).HasColumnName("SecondPageCoverDocumentID");

            entity.HasOne(d => d.ActiveIconDocument)
                .WithMany(p => p.CategoryActiveIconDocument)
                .HasForeignKey(d => d.ActiveIconDocumentId)
                .HasConstraintName("FK_Category_ActiveIconDocument");

            entity.HasOne(d => d.CoverDocument)
                .WithMany(p => p.CategoryCoverDocument)
                .HasForeignKey(d => d.CoverDocumentId)
                .HasConstraintName("FK_Category_CoverDocument");

            entity.HasOne(d => d.SecondPageCoverDocument)
                .WithMany(p => p.CategorySecondPageCoverDocument)
                .HasForeignKey(d => d.SecondPageCoverDocumentId)
                .HasConstraintName("FK_Category_SecondPageCoverDocument");

            entity.HasOne(d => d.InactiveIconDocument)
                .WithMany(p => p.CategoryInactiveIconDocument)
                .HasForeignKey(d => d.InactiveIconDocumentId)
                .HasConstraintName("FK_Category_InactiveIconDocument");

            entity.HasOne(d => d.ParentCategory)
                .WithMany(p => p.InverseParentCategory)
                .HasForeignKey(d => d.ParentCategoryId)
                .HasConstraintName("FK_Category_ParentCategory");

            entity.HasOne(d => d.QuadMenuDocument)
                .WithMany(p => p.CategoryQuadMenuDocument)
                .HasForeignKey(d => d.QuadMenuDocumentId)
                .HasConstraintName("FK_Category_QuadMenuDocument");
        }
    }
}
