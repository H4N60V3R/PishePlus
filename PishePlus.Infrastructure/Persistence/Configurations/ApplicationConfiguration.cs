using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<PishePlus.Domain.Entities.Application>
    {
        public void Configure(EntityTypeBuilder<PishePlus.Domain.Entities.Application> entity)
        {
            entity.HasIndex(e => e.DocumentId);

            entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

            entity.Property(e => e.ApplicationGuid)
                .HasColumnName("ApplicationGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name).IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.VersionCode).HasMaxLength(128);

            entity.HasOne(d => d.Document)
                .WithMany(p => p.Application)
                .HasForeignKey(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Application_Document");
        }
    }
}
