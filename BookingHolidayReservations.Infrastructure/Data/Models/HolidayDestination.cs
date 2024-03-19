using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static BookingHolidayReservations.Infrastructure.Constants.ConstantsValidation;

namespace BookingHolidayReservations.Infrastructure.Data.Models
{
    [Comment("Destination description")]
    public class HolidayDestination
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(HolidayNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(HolidayDescriptionLength)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public decimal PricePerPackage { get; set; }

        [Required]
        public string ImageUrl { get; set; } = string.Empty;


    }
}
