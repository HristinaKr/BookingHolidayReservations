using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookingHolidayReservations.Infrastructure.Constants.ConstantsValidation;
namespace BookingHolidayReservations.Infrastructure.Data.Models
{
    [Comment("User profile")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(UsernameLength)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [MaxLength(EmailLength)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(PasswordMaxLength)]
        public string Password { get; set; } = string.Empty;

    }
}
