using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class ContractorDocumentConfiguration : IEntityTypeConfiguration<ContractorDocument>
    {
        public void Configure(EntityTypeBuilder<ContractorDocument> entity)
        {
            entity.Property(e => e.ContractorDocumentId).HasColumnName("ContractorDocumentID");

            entity.Property(e => e.ContractorDocumentGuid)
                .HasColumnName("ContractorDocumentGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

            entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

            entity.Property(e => e.IsAccept).HasDefaultValueSql("((0))");

            entity.Property(e => e.TitleCodeId).HasColumnName("TitleCodeID");

            entity.HasOne(d => d.Contractor)
                .WithMany(p => p.ContractorDocument)
                .HasForeignKey(d => d.ContractorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractorDocument_Contractor");

            entity.HasOne(d => d.Document)
                .WithMany(p => p.ContractorDocument)
                .HasForeignKey(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContractorDocument_Document");

            entity.HasOne(d => d.TitleCode)
                .WithMany(p => p.ContractorDocument)
                .HasForeignKey(d => d.TitleCodeId)
                .HasConstraintName("FK_ContractorDocument_Code");
        }
    }
}
