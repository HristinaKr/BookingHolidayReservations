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
    internal class PaymentConfig : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            var data = new SeedClasses();

            builder.HasData(new Payment[] { data.PayInformation });
        }
    }
}