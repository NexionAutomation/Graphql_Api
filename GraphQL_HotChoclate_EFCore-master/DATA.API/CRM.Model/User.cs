using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class User
    {
        public User()
        {
            Accounts = new HashSet<Account>();
            Leads = new HashSet<Lead>();
            ProductCreatedByNavigations = new HashSet<Product>();
            ProductLastUpdatedByNavigations = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string UserType { get; set; }
        public bool Active { get; set; }
        public DateTime? JoiningDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public int LastUpdatedBy { get; set; }
        public int? CompanyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Avatar { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Lead> Leads { get; set; }
        public virtual ICollection<Product> ProductCreatedByNavigations { get; set; }
        public virtual ICollection<Product> ProductLastUpdatedByNavigations { get; set; }
    }
    public partial class Users
    {
        public Users()
        {
           
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string UserType { get; set; }
        public bool Active { get; set; }
        public DateTime? JoiningDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public int LastUpdatedBy { get; set; }
        public int? CompanyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Avatar { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Lead> Leads { get; set; }
        public virtual ICollection<Product> ProductCreatedByNavigations { get; set; }
        public virtual ICollection<Product> ProductLastUpdatedByNavigations { get; set; }
    }


}
