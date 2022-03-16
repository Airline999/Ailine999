using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AirlineReservationApp.Repository
{
    public partial class UserDetails
    {
        public UserDetails()
        {
            BookingDetails = new HashSet<BookingDetails>();
            FlightDetails = new HashSet<FlightDetails>();
        }

        public int UserId { get; set; }
        public string UserTitle { get; set; }
        public string UserFirstname { get; set; }
        public string UserLastname { get; set; }
        public int UserPhonenumber { get; set; }
        public string UserEmail { get; set; }
        public DateTime UserDob { get; set; }
        public string UserPassword { get; set; }
        public int? AccountId { get; set; }

        public virtual AccountType Account { get; set; }
        public virtual ICollection<BookingDetails> BookingDetails { get; set; }
        public virtual ICollection<FlightDetails> FlightDetails { get; set; }
    }
}
