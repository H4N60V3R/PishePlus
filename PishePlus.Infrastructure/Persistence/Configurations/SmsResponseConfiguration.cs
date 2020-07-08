using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class SmsResponseConfiguration : IEntityTypeConfiguration<SmsResponse>
    {
        public void Configure(EntityTypeBuilder<SmsResponse> entity)
        {
            entity.ToTable("SMSResponse");

            entity.HasIndex(e => e.SmsTemplateId)
                .HasName("IX_Tbl_SMSResponse_SMS_STID");

            entity.HasIndex(e => e.UserId);

            entity.Property(e => e.SmsResponseId).HasColumnName("SMSResponseID");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.Message).IsRequired();

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Receptor)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.Sender)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.SentDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.SmsResponseGuid)
                .HasColumnName("SMSResponseGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.SmsTemplateId).HasColumnName("SMSTemplateID");

            entity.Property(e => e.StatusText).IsRequired();

            entity.Property(e => e.Token).HasMaxLength(128);

            entity.Property(e => e.Token1).HasMaxLength(128);

            entity.Property(e => e.Token2).HasMaxLength(128);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.SmsTemplate)
                .WithMany(p => p.SmsResponse)
                .HasForeignKey(d => d.SmsTemplateId)
                .HasConstraintName("FK_SMSResponse_SMSTemplate");

            entity.HasOne(d => d.User)
                .WithMany(p => p.Smsresponse)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SMSResponse_User");
        }
    }
}
