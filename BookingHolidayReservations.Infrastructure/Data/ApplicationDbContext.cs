using BookingHolidayReservations.Infrastructure.Data.Models;
using BookingHolidayReservations.Infrastructure.Data.SeedDatabase;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookingHolidayReservations.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BookingConfiguration());
            builder.ApplyConfiguration(new HolidayDestinationConfiguration());
            builder.ApplyConfiguration(new PaymentConfig());
            builder.ApplyConfiguration(new AdminConfiguration());
            builder.ApplyConfiguration(new UsersConfig());

           
            base.OnModelCreating(builder);
        }



        public DbSet<UsersProfile> ApplicationUsers { get; set; } = null!;
        public DbSet<Booking> Bookings { get; set; } = null!;
        public DbSet<HolidayDestination> HolidayDestinations { get; set; } = null!;
        public DbSet<Payment> Payments { get; set; } = null !;
        public DbSet<Administrator> Admins { get; set; } = null!;
    }
}