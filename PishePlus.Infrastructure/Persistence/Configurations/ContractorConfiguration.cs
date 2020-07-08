using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class ContractorConfiguration : IEntityTypeConfiguration<Contractor>
    {
        public void Configure(EntityTypeBuilder<Contractor> entity)
        {
            entity.HasIndex(e => e.BusinessTypeCodeId);

            entity.HasIndex(e => e.CityId);

            entity.HasIndex(e => e.UserId);

            entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

            entity.Property(e => e.BusinessTypeCodeId).HasColumnName("BusinessTypeCodeID");

            entity.Property(e => e.CityId).HasColumnName("CityID");

            entity.Property(e => e.ContractorGuid)
                .HasColumnName("ContractorGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.Instagram).HasMaxLength(128);

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.Latitude)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.Longitude)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Telephone).HasMaxLength(128);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.Website).HasMaxLength(128);

            entity.HasOne(d => d.BusinessTypeCode)
                .WithMany(p => p.Contractor)
                .HasForeignKey(d => d.BusinessTypeCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contractor_Code");

            entity.HasOne(d => d.City)
                .WithMany(p => p.Contractor)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contractor_City");

            entity.HasOne(d => d.User)
                .WithMany(p => p.Contractor)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contractor_User");
        }
    }
}
