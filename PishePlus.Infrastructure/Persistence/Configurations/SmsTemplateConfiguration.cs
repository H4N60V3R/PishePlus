using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class SmsTemplateConfiguration : IEntityTypeConfiguration<SmsTemplate>
    {
        public void Configure(EntityTypeBuilder<SmsTemplate> entity)
        {
            entity.ToTable("SMSTemplate");

            entity.HasIndex(e => e.SmsProviderSettingId)
                .HasName("IX_Tbl_SMSTemplate_ST_SSID");

            entity.Property(e => e.SmsTemplateId).HasColumnName("SMSTemplateID");

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.SmsProviderSettingId).HasColumnName("SMSProviderSettingID");

            entity.Property(e => e.SmsTemplateGuid)
                .HasColumnName("SMSTemplateGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.SmsProviderSetting)
                .WithMany(p => p.SmsTemplate)
                .HasForeignKey(d => d.SmsProviderSettingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMSTemplate_SMSProviderSetting");
        }
    }
}
