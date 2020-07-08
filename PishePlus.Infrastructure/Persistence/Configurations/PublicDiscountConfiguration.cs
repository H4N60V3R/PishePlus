using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class PublicDiscountConfiguration : IEntityTypeConfiguration<PublicDiscount>
    {
        public void Configure(EntityTypeBuilder<PublicDiscount> entity)
        {
            entity.HasIndex(e => e.TypeCodeId);

            entity.Property(e => e.PublicDiscountId).HasColumnName("PublicDiscountID");

            entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.PublicDiscountGuid)
                .HasColumnName("PublicDiscountGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.TypeCodeId).HasColumnName("TypeCodeID");

            entity.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(128);

            entity.HasOne(d => d.TypeCode)
                .WithMany(p => p.PublicDiscount)
                .HasForeignKey(d => d.TypeCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PublicDiscount_Code");
        }
    }
}
