using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> entity)
        {
            entity.HasIndex(e => e.CategoryId);

            entity.HasIndex(e => e.ClientId);

            entity.HasIndex(e => e.ContractorId);

            entity.HasIndex(e => e.StateCodeId);

            entity.Property(e => e.OrderId).HasColumnName("OrderID");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

            entity.Property(e => e.ClientId).HasColumnName("ClientID");

            entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

            entity.Property(e => e.Description).IsRequired();

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.OrderGuid)
                .HasColumnName("OrderGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.StateCodeId).HasColumnName("StateCodeID");

            entity.Property(e => e.Title).IsRequired();

            entity.HasOne(d => d.Category)
                .WithMany(p => p.Order)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Category");

            entity.HasOne(d => d.Client)
                .WithMany(p => p.Order)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Client");

            entity.HasOne(d => d.Contractor)
                .WithMany(p => p.Order)
                .HasForeignKey(d => d.ContractorId)
                .HasConstraintName("FK_Order_Contractor");

            entity.HasOne(d => d.StateCode)
                .WithMany(p => p.Order)
                .HasForeignKey(d => d.StateCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Code");
        }
    }
}
