using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class CodeGroupConfiguration : IEntityTypeConfiguration<CodeGroup>
    {
        public void Configure(EntityTypeBuilder<CodeGroup> entity)
        {
            entity.Property(e => e.CodeGroupId).HasColumnName("CodeGroupID");

            entity.Property(e => e.CodeGroupGuid)
                .HasColumnName("CodeGroupGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.DisplayName).HasMaxLength(128);

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name).HasMaxLength(128);
        }
    }
}
