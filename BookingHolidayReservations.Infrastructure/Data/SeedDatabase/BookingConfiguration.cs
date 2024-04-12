using BookingHolidayReservations.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingHolidayReservations.Infrastructure.Data.SeedDatabase
{
    internal class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder
                .HasOne(b => b.User)
                .WithMany(u => u.Bookings)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(b => b.Payments)
                .WithOne(p => p.Booking)
                .HasForeignKey(p => p.BookingId)
                .OnDelete(DeleteBehavior.Restrict);

            var data = new SeedClasses();
            builder.HasData(new Booking[] { data.HolidayBooking });
        }
    }
}
