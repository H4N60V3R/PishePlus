using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class TokenConfiguration : IEntityTypeConfiguration<Token>
    {
        public void Configure(EntityTypeBuilder<Token> entity)
        {
            entity.HasIndex(e => e.RoleCodeId);

            entity.HasIndex(e => e.UserId);

            entity.Property(e => e.TokenId).HasColumnName("TokenID");

            entity.Property(e => e.ExpireDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.RoleCodeId).HasColumnName("RoleCodeID");

            entity.Property(e => e.TokenGuid)
                .HasColumnName("TokenGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.RoleCode)
                .WithMany(p => p.Token)
                .HasForeignKey(d => d.RoleCodeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Token_Code");

            entity.HasOne(d => d.User)
                .WithMany(p => p.Token)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Token_User");
        }
    }
}
