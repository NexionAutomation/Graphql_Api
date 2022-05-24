using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class State
    {
        public State()
        {
            Accounts = new HashSet<Account>();
            Contacts = new HashSet<Contact>();
        }

        public int Id { get; set; }
        public int? CountryId { get; set; }
        public string Name { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
