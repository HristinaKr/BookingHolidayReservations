using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static BookingHolidayReservations.Infrastructure.Constants.ConstantsValidation;
namespace BookingHolidayReservations.Infrastructure.Data.Models
{
    [Comment("User profile")]
    public class UsersProfile
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(UsernameLength)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [MaxLength(EmailLength)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(PasswordMaxLength)]
        public string Password { get; set; } = null!;

        public List<Booking> Bookings { get; set; } = new List<Booking>();

    }
}
