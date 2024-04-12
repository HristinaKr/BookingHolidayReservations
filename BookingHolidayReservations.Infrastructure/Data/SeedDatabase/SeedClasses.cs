using BookingHolidayReservations.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace BookingHolidayReservations.Infrastructure.Data.SeedDatabase
{
    internal class SeedClasses
    {
        public UsersProfile Person { get; set; } = null!;   
        public UsersProfile Guest { get; set; } = null!;
        public Administrator Admin { get; set; } = null!;
        public Booking HolidayBooking { get; set; } = null!;
        public HolidayDestination BeachResort { get; set; } = null!;
        public HolidayDestination ThroughTheOceanCruise { get; set; } = null!;
        public HolidayDestination Mountain { get; set; } = null!;
        public HolidayDestination HistoricTown { get; set; } = null!;
        public HolidayDestination Wellness { get; set; } = null!;
        public Payment PayInformation { get; set; } = null!;


        public SeedClasses()
        {
            SeedUsers();
            SeedAdmin();
            SeedBooking();
            SeedHolidayDestination();
            SeedPayInformation();
        }
        private void SeedUsers()
        {
            //var hasher = new PasswordHasher<ApplicationUsers>();

            Person = new UsersProfile()
            {
                Id = '1',
               Username = "user11",
                Email = "user@gmail.com",
               Password = "Password",

            };
            //Person.PasswordHash = hasher.HashPassword(Person, "person999");

            Guest = new UsersProfile()
            {
                Id = '2',
               Username = "guest3",
                Email = "guest@gmail.com",
                Password = "Password2",

            };
            //Guest.PasswordHash = hasher.HashPassword(Guest, "guest111");

        }

        private void SeedAdmin()
        {
            Admin = new Administrator()
            {

                Id = 1,
                Username = "admin2024",
                Email = "admin2024@example.com",
                Password = "adminpassword2",
                FullName = "Admin Two",
                PhoneNumber = "0987654321",
                Address = "456 Admin Avenue, Admin Town"
            };

        }

        private void SeedBooking()
        {
            HolidayBooking = new Booking()
            {
                Id = 1,


            };
        }

        private void SeedHolidayDestination()
        {
            BeachResort = new HolidayDestination()
            {
                Id = 1,
                Name = "Lovely beach resorts",
                Description = "Experience beachside bliss at our resort.Relax and enjoy endless ocean views.",
                ImageUrl = "https://dieltours.eu/wp-content/uploads/2023/10/IMG.jpg",
                PricePerPackage = 2000.33m

            };

            ThroughTheOceanCruise = new HolidayDestination()
            {
                Id = 2,
                Name = "Sail through the ocean's beauty",
                Description = "Embark on an unforgettable journey across the open seas.",
                ImageUrl = "https://blue-seas.eu/wp-content/uploads/2020/03/msc_Okolosvetski_kruiz22.jpg",
                PricePerPackage = 14000.33m

            };

            Mountain = new HolidayDestination()
            {
                Id = 3,
                Name = "Experience the thrill of skiing down majestic mountain slope",
                Description = "Embrace the stunning views and adrenaline rush of skiing in the mountains.",
                ImageUrl = "https://assets.vogue.com/photos/657ca3f8e3823f5dc8d413a8/master/w_1600%2Cc_limit/Snowmass%2C%2520Colorado_GettyImages-1135607220.jpg",
                PricePerPackage = 4000.33m

            };

            HistoricTown = new HolidayDestination()
            {
                Id = 4,
                Name = "Step back in time and immerse yourself in the rich history of our charming historic town",
                Description = "Discover the allure of our quaint historic town, where every cobblestone street tells a story.",
                ImageUrl = "https://www.simpsontravel.com/media/12571/historic.jpg?anchor=center&mode=crop&quality=80&width=1200&height=800&rnd=131262030845070000",
                PricePerPackage = 1500.55m

            };

            Wellness = new HolidayDestination()
            {
                Id = 5,
                Name = "Indulge in a wellness getaway",
                Description = "Escape to tranquility with our wellness retreat.",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSakpmgH9ZmFUN1XfyjyPvY2HVI5lelyJC_HQ&usqp=CAU",
                PricePerPackage = 3000.00m

            };
        }

        private void SeedPayInformation()
        {
            var payment = new List<Payment>()
            {
                new Payment
                {
                    Id = 1,
                    BookingId = 1,
                    TotalAmount = 2000.33m,
                    PaymentDate = DateTime.Now,
                  

                },

                new Payment()
                {
                    Id = 2,
                   BookingId = 2,
                    TotalAmount = 14000.33m,
                    PaymentDate = DateTime.Now
                },

                new Payment()
                {
                    Id = 3,
                    BookingId = 3,
                    TotalAmount = 4000.33m,
                    PaymentDate = DateTime.Now
                },

                new Payment()
                {
                    Id = 4,
                    BookingId = 4,
                    TotalAmount = 1500.55m,
                    PaymentDate = DateTime.Now
                },

                new Payment()
                {
                    Id = 5,
                    BookingId = 5,
                    TotalAmount = 3000.00m,
                    PaymentDate = DateTime.Now
                }


            };
          
        }
    }
}