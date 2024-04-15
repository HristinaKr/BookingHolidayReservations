using BookingHolidayReservations.Core.Contracts;
using BookingHolidayReservations.Core.Models.Home;
using BookingHolidayReservations.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BookingHolidayReservations.Core.Services
{
    public class HolidaysService : IHolidaysService
    {
        private readonly IRepository repository;
        public HolidaysService(IRepository _repository)
        {
            repository = _repository;
        }


        public async Task<IEnumerable<TripsIndexService>> AllTrips()
        {

            return await repository
                .AllReadOnly<Infrastructure.Data.Models.HolidayDestination>()
                .Select(x => new TripsIndexService() { Id = x.Id, ImageUrl = x.ImageUrl, TripName = x.Name })
                .ToListAsync();
        }

    }
}
