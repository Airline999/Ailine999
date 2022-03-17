using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FlightBookingApp.Models
{
    public partial class PaymentDetails
    {
        public int TransactionId { get; set; }
        public string PaymentType { get; set; }
        public DateTime? PaymentDate { get; set; }
        public TimeSpan? PaymentTime { get; set; }
        public int AmountPaid { get; set; }
        public int? BookingId { get; set; }

        public virtual BookingDetails Booking { get; set; }
    }
}
