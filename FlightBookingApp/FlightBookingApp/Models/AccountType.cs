using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FlightBookingApp.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            UserDetails = new HashSet<UserDetails>();
        }

        public int AccountId { get; set; }
        public string AccountType1 { get; set; }

        public virtual ICollection<UserDetails> UserDetails { get; set; }
    }
}
