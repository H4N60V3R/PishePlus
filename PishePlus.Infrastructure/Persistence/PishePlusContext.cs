using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PishePlus.Application.Common.Interfaces;
using PishePlus.Domain.Common;
//using PishePlus.Application.Common.Interfaces;
//using PishePlus.Domain.Common;
using PishePlus.Domain.Entities;

namespace PishePlus.Infrastructure.Persistence
{
    public partial class PishePlusContext : DbContext, IPishePlusContext
    {
        private readonly ICurrentUserService _currentUserService;
        //private readonly IDateTime _dateTime;

        public PishePlusContext()
        {
        }

        public PishePlusContext(
            DbContextOptions<PishePlusContext> options,
            ICurrentUserService currentUserService/*,*/
            /*IDateTime dateTime*/) : base(options)
        {
            _currentUserService = currentUserService;
            //_dateTime = dateTime;
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Advertisement> Advertisement { get; set; }
        public virtual DbSet<PishePlus.Domain.Entities.Application> Application { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryTag> CategoryTag { get; set; }
        public virtual DbSet<ChatMessage> ChatMessage { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Code> Code { get; set; }
        public virtual DbSet<CodeGroup> CodeGroup { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Complaint> Complaint { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<Contractor> Contractor { get; set; }
        public virtual DbSet<ContractorCategory> ContractorCategory { get; set; }
        public virtual DbSet<ContractorDiscount> ContractorDiscount { get; set; }
        public virtual DbSet<ContractorDocument> ContractorDocument { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderRequest> OrderRequest { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PaymentProvider> PaymentProvider { get; set; }
        public virtual DbSet<PaymentProviderSetting> PaymentProviderSetting { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PermissionGroup> PermissionGroup { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<PostCategory> PostCategory { get; set; }
        public virtual DbSet<PostComment> PostComment { get; set; }
        public virtual DbSet<PostTag> PostTag { get; set; }
        public virtual DbSet<PrivateDiscount> PrivateDiscount { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<PublicDiscount> PublicDiscount { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RolePermission> RolePermission { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<SmsProvider> SmsProvider { get; set; }
        public virtual DbSet<SmsProviderSetting> SmsProviderSetting { get; set; }
        public virtual DbSet<SmsProviderSettingNumber> SmsProviderSettingNumber { get; set; }
        public virtual DbSet<SmsResponse> SmsResponse { get; set; }
        public virtual DbSet<SmsTemplate> SmsTemplate { get; set; }
        public virtual DbSet<Suggestion> Suggestion { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Token> Token { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserPermission> UserPermission { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.Created = DateTime.UtcNow;
                        //entry.Entity.Created = _dateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModified = DateTime.UtcNow;
                        //entry.Entity.LastModified = _dateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed();
            
            OnModelCreatingPartial(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
