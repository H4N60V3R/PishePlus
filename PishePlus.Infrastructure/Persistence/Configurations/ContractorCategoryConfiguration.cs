using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class ContractorCategoryConfiguration : IEntityTypeConfiguration<ContractorCategory>
    {
        public void Configure(EntityTypeBuilder<ContractorCategory> entity)
        {
            entity.HasIndex(e => e.CategoryId);

            entity.HasIndex(e => e.ContractorId);

            entity.Property(e => e.ContractorCategoryId).HasColumnName("ContractorCategoryID");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

            entity.Property(e => e.ContractorCategoryGuid)
                .HasColumnName("ContractorCategoryGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

            entity.HasOne(d => d.Category)
                .WithMany(p => p.ContractorCategory)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractorCategory_Category");

            entity.HasOne(d => d.Contractor)
                .WithMany(p => p.ContractorCategory)
                .HasForeignKey(d => d.ContractorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractorCategory_Contractor");
        }
    }
}
