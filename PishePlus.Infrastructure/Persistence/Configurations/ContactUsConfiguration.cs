using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class ContactUsConfiguration : IEntityTypeConfiguration<ContactUs>
    {
        public void Configure(EntityTypeBuilder<ContactUs> entity)
        {
            entity.HasIndex(e => e.ContactUsBusinessTypeCodeId);

            entity.Property(e => e.ContactUsId).HasColumnName("ContactUsID");

            entity.Property(e => e.ContactUsBusinessTypeCodeId).HasColumnName("ContactUsBusinessTypeCodeID");

            entity.Property(e => e.ContactUsGuid)
                .HasColumnName("ContactUsGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.CreationDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(128);

            entity.HasOne(d => d.ContactUsBusinessTypeCode)
                .WithMany(p => p.ContactUs)
                .HasForeignKey(d => d.ContactUsBusinessTypeCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContactUs_Code");
        }
    }
}
