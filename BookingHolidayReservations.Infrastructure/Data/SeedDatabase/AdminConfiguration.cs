using BookingHolidayReservations.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingHolidayReservations.Infrastructure.Data.SeedDatabase
{
    internal class AdminConfiguration : IEntityTypeConfiguration<Administrator>
    {
        public void Configure(EntityTypeBuilder<Administrator> builder)
        {
            var data = new SeedClasses();

            builder.HasData(new Administrator[] { data.Admin });
        }
    }
}
