using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class User
    {
        public User()
        {
            Admin = new HashSet<Admin>();
            ChatMessage = new HashSet<ChatMessage>();
            Client = new HashSet<Client>();
            Comment = new HashSet<Comment>();
            Complaint = new HashSet<Complaint>();
            Contractor = new HashSet<Contractor>();
            Post = new HashSet<Post>();
            Smsresponse = new HashSet<SmsResponse>();
            Suggestion = new HashSet<Suggestion>();
            Token = new HashSet<Token>();
            UserPermission = new HashSet<UserPermission>();
        }

        public int UserId { get; set; }
        public Guid UserGuid { get; set; }
        public int RoleId { get; set; }
        public int? GenderCodeId { get; set; }
        public int? ProfileDocumentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsRegister { get; set; }
        public bool IsDelete { get; set; }
        public DateTime RegisteredDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Code GenderCode { get; set; }
        public virtual Document ProfileDocument { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Admin> Admin { get; set; }
        public virtual ICollection<ChatMessage> ChatMessage { get; set; }
        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Complaint> Complaint { get; set; }
        public virtual ICollection<Contractor> Contractor { get; set; }
        public virtual ICollection<Post> Post { get; set; }
        public virtual ICollection<SmsResponse> Smsresponse { get; set; }
        public virtual ICollection<Suggestion> Suggestion { get; set; }
        public virtual ICollection<Token> Token { get; set; }
        public virtual ICollection<UserPermission> UserPermission { get; set; }
    }
}
