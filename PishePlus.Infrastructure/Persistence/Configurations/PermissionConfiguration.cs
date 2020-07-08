using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> entity)
        {
            entity.HasIndex(e => e.PermissionGroupId);

            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

            entity.Property(e => e.DisplayName)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.PermissionGroupId).HasColumnName("PermissionGroupID");

            entity.Property(e => e.PermissionGuid)
                .HasColumnName("PermissionGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.PermissionGroup)
                .WithMany(p => p.Permission)
                .HasForeignKey(d => d.PermissionGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Permission_PermissionGroup");
        }
    }
}
