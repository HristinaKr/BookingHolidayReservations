using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingHolidayReservations.Infrastructure.Constants
{
    public static class ConstantsValidation
    {
        public const int UsernameLength = 60;
        public const int EmailLength = 100;
        public const int PasswordMinLength = 6;
        public const int PasswordMaxLength = 40;

        public const int GuestsMinCount = 1;
        public const int GuestsMaxCount = 50;

        public const int HolidayNameMaxLength = 100;
        public const int HolidayDescriptionLength = 500;

        public const int AdminUsernameLength = 100;
        public const int AdminEmailLength = 100;
        public const int AdminPasswordMinLength = 6;
        public const int AdminPasswordMaxLength = 100;
        public const int AdminFullNameLength = 100;
        public const int AdminPhoneNumberLength = 15;
        public const int AdminAddressLength = 100;
    }
}
