using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AirlineReservationApp.Repository
{
    public partial class BookingStatus
    {
        public BookingStatus()
        {
            BookingDetails = new HashSet<BookingDetails>();
        }

        public int BookingNo { get; set; }
        public string BookingStatus1 { get; set; }

        public virtual ICollection<BookingDetails> BookingDetails { get; set; }
    }
}
