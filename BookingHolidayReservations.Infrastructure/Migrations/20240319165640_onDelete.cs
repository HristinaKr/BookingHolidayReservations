using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingHolidayReservations.Infrastructure.Migrations
{
    public partial class onDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_ApplicationUsers_UserId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_HolidayDestinations_Bookings_BookingId",
                table: "HolidayDestinations");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Bookings_BookingId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_HolidayDestinations_BookingId",
                table: "HolidayDestinations");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "HolidayDestinations");

            migrationBuilder.CreateTable(
                name: "BookingHolidayDestination",
                columns: table => new
                {
                    BookingsId = table.Column<int>(type: "int", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingHolidayDestination", x => new { x.BookingsId, x.DestinationId });
                    table.ForeignKey(
                        name: "FK_BookingHolidayDestination_Bookings_BookingsId",
                        column: x => x.BookingsId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingHolidayDestination_HolidayDestinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "HolidayDestinations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingHolidayDestination_DestinationId",
                table: "BookingHolidayDestination",
                column: "DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_ApplicationUsers_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Bookings_BookingId",
                table: "Payments",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_ApplicationUsers_UserId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Bookings_BookingId",
                table: "Payments");

            migrationBuilder.DropTable(
                name: "BookingHolidayDestination");

            migrationBuilder.AddColumn<int>(
                name: "BookingId",
                table: "HolidayDestinations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HolidayDestinations_BookingId",
                table: "HolidayDestinations",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_ApplicationUsers_UserId",
                table: "Bookings",
                column: "UserId",
                principalTable: "ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HolidayDestinations_Bookings_BookingId",
                table: "HolidayDestinations",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Bookings_BookingId",
                table: "Payments",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
