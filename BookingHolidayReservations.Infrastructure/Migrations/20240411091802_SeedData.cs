using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingHolidayReservations.Infrastructure.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsConfirmed",
                table: "Bookings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Address", "Email", "FullName", "Password", "PhoneNumber", "Username" },
                values: new object[] { 1, "456 Admin Avenue, Admin Town", "admin2024@example.com", "Admin Two", "adminpassword2", "0987654321", "admin2024" });

            migrationBuilder.InsertData(
                table: "ApplicationUsers",
                columns: new[] { "Id", "Email", "Password", "Username" },
                values: new object[,]
                {
                    { 49, "user@gmail.com", "Password", "user11" },
                    { 50, "guest@gmail.com", "Password2", "guest3" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "DestinationId", "IsConfirmed", "NumberOfGuests", "UserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, 0, 0 });

            migrationBuilder.InsertData(
                table: "HolidayDestinations",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "PricePerPackage" },
                values: new object[,]
                {
                    { 1, "Experience beachside bliss at our resort.Relax and enjoy endless ocean views.", "https://dieltours.eu/wp-content/uploads/2023/10/IMG.jpg", "Lovely beach resorts", 2000.33m },
                    { 2, "Embark on an unforgettable journey across the open seas.", "https://blue-seas.eu/wp-content/uploads/2020/03/msc_Okolosvetski_kruiz22.jpg", "Sail through the ocean's beauty", 14000.33m },
                    { 3, "Embrace the stunning views and adrenaline rush of skiing in the mountains.", "https://assets.vogue.com/photos/657ca3f8e3823f5dc8d413a8/master/w_1600%2Cc_limit/Snowmass%2C%2520Colorado_GettyImages-1135607220.jpg", "Experience the thrill of skiing down majestic mountain slope", 4000.33m },
                    { 4, "Discover the allure of our quaint historic town, where every cobblestone street tells a story.", "https://www.simpsontravel.com/media/12571/historic.jpg?anchor=center&mode=crop&quality=80&width=1200&height=800&rnd=131262030845070000", "Step back in time and immerse yourself in the rich history of our charming historic town", 1500.55m },
                    { 5, "Escape to tranquility with our wellness retreat.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSakpmgH9ZmFUN1XfyjyPvY2HVI5lelyJC_HQ&usqp=CAU", "Indulge in a wellness getaway", 3000.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ApplicationUsers",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HolidayDestinations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HolidayDestinations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HolidayDestinations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HolidayDestinations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HolidayDestinations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "IsConfirmed",
                table: "Bookings");
        }
    }
}
