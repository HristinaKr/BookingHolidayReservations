using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingHolidayReservations.Infrastructure.Data.Models;

namespace BookingHolidayReservations.Infrastructure.Data.SeedDatabase
{
    internal class HolidayDestinationConfiguration : IEntityTypeConfiguration<HolidayDestination>
    {
        public void Configure(EntityTypeBuilder<HolidayDestination> builder)
        {
            var data = new SeedClasses();

            builder.HasData(new HolidayDestination[] { data.BeachResort, data.ThroughTheOceanCruise, data.Mountain,
            data.HistoricTown, data.Wellness});
        }
    }
}