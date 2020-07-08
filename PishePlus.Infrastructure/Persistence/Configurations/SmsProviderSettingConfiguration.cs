using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class SmsProviderSettingConfiguration : IEntityTypeConfiguration<SmsProviderSetting>
    {
        public void Configure(EntityTypeBuilder<SmsProviderSetting> entity)
        {
            entity.ToTable("SMSProviderSetting");

            entity.HasIndex(e => e.SmsProviderId);

            entity.Property(e => e.SmsProviderSettingId).HasColumnName("SMSProviderSettingID");

            entity.Property(e => e.Apikey)
                .IsRequired()
                .HasColumnName("APIKey")
                .HasMaxLength(128);

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.SmsProviderId).HasColumnName("SMSProviderID");

            entity.Property(e => e.SmsProviderSettingGuid)
                .HasColumnName("SMSProviderSettingGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(128);

            entity.HasOne(d => d.SmsProvider)
                .WithMany(p => p.SmsProviderSetting)
                .HasForeignKey(d => d.SmsProviderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMSProviderSetting_SMSProvider");
        }
    }
}
