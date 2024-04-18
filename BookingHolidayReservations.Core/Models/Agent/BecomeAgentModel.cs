using System.ComponentModel.DataAnnotations;
using static BookingHolidayReservations.Core.Constants.Messages;
using static BookingHolidayReservations.Infrastructure.Constants.ConstantsValidation;

namespace BookingHolidayReservations.Core.Models.Agent
{
    public class BecomeAgentModel
    { 
            [Required(ErrorMessage = RequiredMessage)]
            [StringLength(AdminPhoneNumberLength,
                ErrorMessage = LengthMessage)]
            [Display(Name = "Phone number")]
            [Phone]
            public string PhoneNumber { get; set; } = null!;
        
    }
}
