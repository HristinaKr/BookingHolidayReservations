using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BookingHolidayReservations.Infrastructure.Constants.ConstantsValidation;

namespace BookingHolidayReservations.Infrastructure.Data.Models
{
    [Comment("Holiday bookings made by the user")]
    public class Booking
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; } 

        [Required]
        public int DestinationId { get; set; }

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        [Required]
        [MaxLength(GuestsMaxCount)]
        public int NumberOfGuests { get; set; }

        [Required]
        public bool IsConfirmed { get; set; }

        [ForeignKey(nameof(UserId))]
        public UsersProfile User { get; set; } = null!;

        public List<HolidayDestination> Destination { get; set; } = new List<HolidayDestination>();
      
        public List<Payment> Payments { get; set; } = new List<Payment>();
    }
}
