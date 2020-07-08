using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class SmsProviderSettingNumberConfiguration : IEntityTypeConfiguration<SmsProviderSettingNumber>
    {
        public void Configure(EntityTypeBuilder<SmsProviderSettingNumber> entity)
        {
            entity.ToTable("SMSProviderSettingNumber");

            entity.HasIndex(e => e.SmsProviderSettingId)
                .HasName("IX_Tbl_SMSProviderNumber_SPN_SPCID");

            entity.Property(e => e.SmsProviderSettingNumberId).HasColumnName("SMSProviderSettingNumberID");

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.SmsProviderSettingId).HasColumnName("SMSProviderSettingID");

            entity.Property(e => e.SmsProviderSettingNumberGuid)
                .HasColumnName("SMSProviderSettingNumberGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(128);

            entity.HasOne(d => d.SmsProviderSetting)
                .WithMany(p => p.SmsProviderSettingNumber)
                .HasForeignKey(d => d.SmsProviderSettingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMSProviderSettingNumber_SMSProviderSetting");
        }
    }
}
