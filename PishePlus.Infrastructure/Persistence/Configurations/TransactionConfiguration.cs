using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> entity)
        {
            entity.HasIndex(e => e.TypeCodeId);

            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Serial)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.TransactionGuid)
                .HasColumnName("TransactionGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.TypeCodeId).HasColumnName("TypeCodeID");

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.TypeCode)
                .WithMany(p => p.Transaction)
                .HasForeignKey(d => d.TypeCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_Code");
        }
    }
}
