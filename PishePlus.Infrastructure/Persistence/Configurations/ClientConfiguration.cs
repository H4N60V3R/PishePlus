using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> entity)
        {
            entity.HasIndex(e => e.CityId);

            entity.HasIndex(e => e.UserId);

            entity.Property(e => e.ClientId).HasColumnName("ClientID");

            entity.Property(e => e.CityId).HasColumnName("CityID");

            entity.Property(e => e.ClientGuid)
                .HasColumnName("ClientGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.City)
                .WithMany(p => p.Client)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Client_City");

            entity.HasOne(d => d.User)
                .WithMany(p => p.Client)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Client_User");
        }
    }
}
