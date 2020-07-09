using Microsoft.EntityFrameworkCore;
using PishePlus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PishePlus.Application.Common.Interfaces
{
    public interface IPishePlusContext
    {
        DbSet<Admin> Admin { get; set; }
        DbSet<Advertisement> Advertisement { get; set; }
        DbSet<Category> Category { get; set; }
        DbSet<CategoryTag> CategoryTag { get; set; }
        DbSet<ChatMessage> ChatMessage { get; set; }
        DbSet<City> City { get; set; }
        DbSet<Client> Client { get; set; }
        DbSet<Code> Code { get; set; }
        DbSet<CodeGroup> CodeGroup { get; set; }
        DbSet<Comment> Comment { get; set; }
        DbSet<Complaint> Complaint { get; set; }
        DbSet<ContactUs> ContactUs { get; set; }
        DbSet<Contractor> Contractor { get; set; }
        DbSet<ContractorCategory> ContractorCategory { get; set; }
        DbSet<ContractorDiscount> ContractorDiscount { get; set; }
        DbSet<ContractorDocument> ContractorDocument { get; set; }
        DbSet<Document> Document { get; set; }
        DbSet<Order> Order { get; set; }
        DbSet<OrderRequest> OrderRequest { get; set; }
        DbSet<Payment> Payment { get; set; }
        DbSet<PaymentProvider> PaymentProvider { get; set; }
        DbSet<PaymentProviderSetting> PaymentProviderSetting { get; set; }
        DbSet<Permission> Permission { get; set; }
        DbSet<PermissionGroup> PermissionGroup { get; set; }
        DbSet<Post> Post { get; set; }
        DbSet<PostCategory> PostCategory { get; set; }
        DbSet<PostComment> PostComment { get; set; }
        DbSet<PostTag> PostTag { get; set; }
        DbSet<PrivateDiscount> PrivateDiscount { get; set; }
        DbSet<Province> Province { get; set; }
        DbSet<PublicDiscount> PublicDiscount { get; set; }
        DbSet<Role> Role { get; set; }
        DbSet<RolePermission> RolePermission { get; set; }
        DbSet<Setting> Setting { get; set; }
        DbSet<SmsProvider> SmsProvider { get; set; }
        DbSet<SmsProviderSetting> SmsProviderSetting { get; set; }
        DbSet<SmsProviderSettingNumber> SmsProviderSettingNumber { get; set; }
        DbSet<SmsResponse> SmsResponse { get; set; }
        DbSet<SmsTemplate> SmsTemplate { get; set; }
        DbSet<Suggestion> Suggestion { get; set; }
        DbSet<Tag> Tag { get; set; }
        DbSet<Token> Token { get; set; }
        DbSet<Transaction> Transaction { get; set; }
        DbSet<User> User { get; set; }
        DbSet<UserPermission> UserPermission { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
