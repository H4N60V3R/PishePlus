using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> entity)
        {
            entity.HasIndex(e => e.ContractorId);

            entity.HasIndex(e => e.PaymentProviderSettingId);

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

            entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

            entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PaymentGuid)
                .HasColumnName("PaymentGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.PaymentProviderSettingId).HasColumnName("PaymentProviderSettingID");

            entity.HasOne(d => d.Contractor)
                .WithMany(p => p.Payment)
                .HasForeignKey(d => d.ContractorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payment_Contractor");

            entity.HasOne(d => d.PaymentProviderSetting)
                .WithMany(p => p.Payment)
                .HasForeignKey(d => d.PaymentProviderSettingId);
        }
    }
}
