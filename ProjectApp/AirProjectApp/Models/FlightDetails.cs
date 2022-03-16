using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AirProjectApp.Models
{
    public partial class FlightDetails
    {
        public FlightDetails()
        {
            BookingDetails = new HashSet<BookingDetails>();
        }

        public int FlightId { get; set; }
        public string FlightName { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public TimeSpan? ArrivalTime { get; set; }
        public TimeSpan? DepartureTime { get; set; }
        public int? NoOfSeats { get; set; }
        public int CreatedBy { get; set; }

        public virtual UserDetails CreatedByNavigation { get; set; }
        public virtual ICollection<BookingDetails> BookingDetails { get; set; }
    }
}
