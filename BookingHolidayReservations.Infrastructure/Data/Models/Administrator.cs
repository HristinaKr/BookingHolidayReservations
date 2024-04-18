using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static BookingHolidayReservations.Infrastructure.Constants.ConstantsValidation;

namespace BookingHolidayReservations.Infrastructure.Data.Models
{
    [Index(nameof(PhoneNumber), IsUnique = true)]
    [Comment("Admin functions")]
    public class Administrator
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(AdminUsernameLength)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [MaxLength(AdminEmailLength)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(AdminPasswordMaxLength)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [MaxLength(AdminFullNameLength)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [MaxLength(AdminPhoneNumberLength)]
        public string PhoneNumber { get; set; } = string.Empty;

        [MaxLength(AdminAddressLength)]
        public string Address { get; set; } = string.Empty;
    }
}
