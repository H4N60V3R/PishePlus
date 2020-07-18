using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class OrderRequestConfiguration : IEntityTypeConfiguration<OrderRequest>
    {
        public void Configure(EntityTypeBuilder<OrderRequest> entity)
        {
            entity.HasIndex(e => e.ContractorId);

            entity.HasIndex(e => e.OrderId);

            entity.HasIndex(e => e.StateCodeId);

            entity.Property(e => e.OrderRequestId).HasColumnName("OrderRequestID");

            entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

            entity.Property(e => e.Message).IsRequired();

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.IsAllow).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");

            entity.Property(e => e.StateCodeId).HasColumnName("StateCodeID");

            entity.Property(e => e.Title).IsRequired();

            entity.Property(e => e.OrderRequestGuid)
                .HasColumnName("OrderRequestGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Contractor)
                .WithMany(p => p.OrderRequest)
                .HasForeignKey(d => d.ContractorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderRequest_Contractor");

            entity.HasOne(d => d.Order)
                .WithMany(p => p.OrderRequest)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderRequest_Order");

            entity.HasOne(d => d.StateCode)
                .WithMany(p => p.OrderRequest)
                .HasForeignKey(d => d.StateCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderRequest_StateCode");
        }
    }
}
