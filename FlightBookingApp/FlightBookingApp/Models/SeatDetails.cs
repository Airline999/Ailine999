using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FlightBookingApp.Models
{
    public partial class SeatDetails
    {
        public SeatDetails()
        {
            BookingDetails = new HashSet<BookingDetails>();
        }

        public int SeatNo { get; set; }
        public string SeatType { get; set; }

        public virtual ICollection<BookingDetails> BookingDetails { get; set; }
    }
}
