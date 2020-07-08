using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class PrivateDiscountConfiguration : IEntityTypeConfiguration<PrivateDiscount>
    {
        public void Configure(EntityTypeBuilder<PrivateDiscount> entity)
        {
            entity.HasIndex(e => e.ContractorId);

            entity.HasIndex(e => e.TypeCodeId);

            entity.Property(e => e.PrivateDiscountId).HasColumnName("PrivateDiscountID");

            entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

            entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.PrivateDiscountGuid)
                .HasColumnName("PrivateDiscountGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.TypeCodeId).HasColumnName("TypeCodeID");

            entity.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(128);

            entity.HasOne(d => d.Contractor)
                .WithMany(p => p.PrivateDiscount)
                .HasForeignKey(d => d.ContractorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrivateDiscount_Contractor");

            entity.HasOne(d => d.TypeCode)
                .WithMany(p => p.PrivateDiscount)
                .HasForeignKey(d => d.TypeCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrivateDiscount_Code");
        }
    }
}
