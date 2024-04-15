using BookingHolidayReservations.Core.Models.Home;

namespace BookingHolidayReservations.Core.Contracts
{
    public interface IHolidaysService
    {
        Task<IEnumerable<TripsIndexService>> AllTrips();
    }
}
