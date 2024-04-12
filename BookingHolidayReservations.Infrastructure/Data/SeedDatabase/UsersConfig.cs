using BookingHolidayReservations.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookingHolidayReservations.Infrastructure.Data.SeedDatabase
{
    internal class UsersConfig : IEntityTypeConfiguration<UsersProfile>
    {
        public void Configure(EntityTypeBuilder<UsersProfile> builder)
        {
            var data = new SeedClasses();

            builder.HasData(new UsersProfile[] { data.Person, data.Guest });
        }
    }
}
