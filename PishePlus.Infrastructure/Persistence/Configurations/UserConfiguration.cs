using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PishePlus.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasIndex(e => e.GenderCodeId);

            entity.HasIndex(e => e.ProfileDocumentId);

            entity.HasIndex(e => e.RoleId);

            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.Property(e => e.Email).HasMaxLength(128);

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.GenderCodeId).HasColumnName("GenderCodeID");

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

            entity.Property(e => e.IsDelete).HasDefaultValueSql("((0))");

            entity.Property(e => e.IsRegister).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.ProfileDocumentId).HasColumnName("ProfileDocumentID");

            entity.Property(e => e.RegisteredDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.RoleId).HasColumnName("RoleID");

            entity.Property(e => e.UserGuid)
                .HasColumnName("UserGUID")
                .HasColumnType("UNIQUEIDENTIFIER ROWGUIDCOL")
                .HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.GenderCode)
                .WithMany(p => p.User)
                .HasForeignKey(d => d.GenderCodeId)
                .HasConstraintName("FK_User_Code");

            entity.HasOne(d => d.ProfileDocument)
                .WithMany(p => p.User)
                .HasForeignKey(d => d.ProfileDocumentId);

            entity.HasOne(d => d.Role)
                .WithMany(p => p.User)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Role");

            //entity.HasQueryFilter(e => !e.IsDelete);
        }
    }
}
