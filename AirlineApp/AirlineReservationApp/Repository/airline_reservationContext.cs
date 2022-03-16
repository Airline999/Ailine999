using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AirlineReservationApp.Repository
{
    public partial class airline_reservationContext : DbContext
    {
        public airline_reservationContext()
        {
        }

        public airline_reservationContext(DbContextOptions<airline_reservationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountType> AccountType { get; set; }
        public virtual DbSet<BookingDetails> BookingDetails { get; set; }
        public virtual DbSet<BookingStatus> BookingStatus { get; set; }
        public virtual DbSet<FlightDetails> FlightDetails { get; set; }
        public virtual DbSet<PaymentDetails> PaymentDetails { get; set; }
        public virtual DbSet<SeatDetails> SeatDetails { get; set; }
        public virtual DbSet<UserDetails> UserDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-MKO0DM0;Database=airline_reservation;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK__AccountT__349DA5860008B9E2");

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountType1)
                    .IsRequired()
                    .HasColumnName("AccountType")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BookingDetails>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK__BookingD__73951AED1FAD6F94");

                entity.Property(e => e.BookingId).ValueGeneratedNever();

                entity.Property(e => e.BookingFlightId).HasColumnName("BookingFlightID");

                entity.Property(e => e.BookingUserId).HasColumnName("BookingUserID");

                entity.HasOne(d => d.BookingFlight)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.BookingFlightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkey_bfid_fid");

                entity.HasOne(d => d.BookingNoNavigation)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.BookingNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkey_bno_bnos");

                entity.HasOne(d => d.BookingUser)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.BookingUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkey_buid_uid");

                entity.HasOne(d => d.SeatNoNavigation)
                    .WithMany(p => p.BookingDetails)
                    .HasForeignKey(d => d.SeatNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkey_sno_sno");
            });

            modelBuilder.Entity<BookingStatus>(entity =>
            {
                entity.HasKey(e => e.BookingNo)
                    .HasName("PK__BookingS__739788AA1557633A");

                entity.Property(e => e.BookingNo).ValueGeneratedNever();

                entity.Property(e => e.BookingStatus1)
                    .IsRequired()
                    .HasColumnName("BookingStatus")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FlightDetails>(entity =>
            {
                entity.HasKey(e => e.FlightId)
                    .HasName("PK__FlightDe__8A9E148ED1DBF8E9");

                entity.Property(e => e.FlightId)
                    .HasColumnName("FlightID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FlightName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FromLocation)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ToLocation)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.FlightDetails)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkey_cb_admn");
            });

            modelBuilder.Entity<PaymentDetails>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__PaymentD__55433A4B097BBA8C");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.PaymentDetails)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("fkey_pid_bookid");
            });

            modelBuilder.Entity<SeatDetails>(entity =>
            {
                entity.HasKey(e => e.SeatNo)
                    .HasName("PK__SeatDeta__3116FB415A3409B1");

                entity.Property(e => e.SeatNo).ValueGeneratedNever();

                entity.Property(e => e.SeatType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserDetails>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserDeta__1788CCACC96B103B");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.UserDob).HasColumnType("date");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserFirstname)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UserLastname)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UserTitle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("fkey_aid_aid");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
