using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class AdvertisementConfiguration : IEntityTypeConfiguration<Advertisement>
    {
        public void Configure(EntityTypeBuilder<Advertisement> entity)
        {
            entity.HasIndex(e => e.DocumentId);

            entity.Property(e => e.AdvertisementId).HasColumnName("AdvertisementID");

            entity.Property(e => e.AdvertisementGuid)
                .HasColumnName("AdvertisementGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.Description).IsRequired();

            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.IsShow).HasDefaultValueSql("((1))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Title).IsRequired();

            entity.HasOne(d => d.Document)
                .WithMany(p => p.Advertisement)
                .HasForeignKey(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Advertisement_Document");
        }
    }
}
