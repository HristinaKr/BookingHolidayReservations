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

            builder.Entity<Booking>()
                .HasOne(b => b.User)
                .WithMany(u => u.Bookings)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Restrict); 

            builder.Entity<Booking>()
                .HasMany(b => b.Payments)
                .WithOne(p => p.Booking)
                .HasForeignKey(p => p.BookingId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }



        public DbSet<User> ApplicationUsers { get; set; } = null!;
        public DbSet<Booking> Bookings { get; set; } = null!;
        public DbSet<HolidayDestination> HolidayDestinations { get; set; } = null!;
        public DbSet<Payment> Payments { get; set; } = null!;
        public DbSet<Administrator> Admins { get; set; } = null!;
    }
}