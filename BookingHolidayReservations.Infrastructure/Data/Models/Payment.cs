using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookingHolidayReservations.Infrastructure.Data.Models
{
    public class Payment
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Comment("Payment information about the booking")]
        public int Id { get; set; }

        [Required]
        public int BookingId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [ForeignKey(nameof(BookingId))]
        public Booking Booking { get; set; } = new Booking();
    }
}
