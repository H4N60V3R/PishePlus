using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class CodeConfiguration : IEntityTypeConfiguration<Code>
    {
        public void Configure(EntityTypeBuilder<Code> entity)
        {
            entity.HasIndex(e => e.CodeGroupId)
                    .HasName("IX_Tbl_Code_Code_CGID");

            entity.Property(e => e.CodeId).HasColumnName("CodeID");

            entity.Property(e => e.CodeGroupId).HasColumnName("CodeGroupID");

            entity.Property(e => e.CodeGuid)
                .HasColumnName("CodeGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.DisplayName).HasMaxLength(128);

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.CodeGroup)
                .WithMany(p => p.Code)
                .HasForeignKey(d => d.CodeGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Code_CodeGroup");
        }
    }
}
