using BookingHolidayReservations.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHolidayReservations.Infrastructure.Data.SeedDatabase
{
    internal class UsersConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var data = new SeedClasses();

            builder.HasData(new User[] { data.Person, data.Guest });
        }
    }
}
