using BookingHolidayReservations.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingHolidayReservations.Infrastructure.Data.SeedDatabase
{
    internal class PaymentConfig : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            var data = new SeedClasses();

            if (data.PayInformation != null)
            {
                builder.HasData(new Payment[] { data.PayInformation });
            }

          //  builder.HasData(new Payment[] { data.PayInformation });
        }
    }
}