using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FlightBookingApp.Models
{
    public partial class BookingDetails
    {
        public BookingDetails()
        {
            PaymentDetails = new HashSet<PaymentDetails>();
        }

        public int BookingId { get; set; }
        public int BookingUserId { get; set; }
        public int BookingFlightId { get; set; }
        public int SeatNo { get; set; }
        public int NoOfSeats { get; set; }
        public int BookingNo { get; set; }

        public virtual FlightDetails BookingFlight { get; set; }
        public virtual BookingStatus BookingNoNavigation { get; set; }
        public virtual UserDetails BookingUser { get; set; }
        public virtual SeatDetails SeatNoNavigation { get; set; }
        public virtual ICollection<PaymentDetails> PaymentDetails { get; set; }
    }
}
