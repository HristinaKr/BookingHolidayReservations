using BookingHolidayReservations.Core.Contracts;
using BookingHolidayReservations.Infrastructure.Data.Common;
using BookingHolidayReservations.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingHolidayReservations.Core.Services
{
    public class AgentService : IAgentService
    {
        private readonly IRepository repository;
        public AgentService(IRepository _repository)
        {
                repository = _repository;   
        }

        public Task CreateAsync(string userId, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsById(string userId)
        {
            return await repository.AllReadOnly<Administrator>()
                .AnyAsync(a => a.Id.ToString() == userId);
        }

        public Task<int?> GetAgentIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserHasRentsAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserWithPhoneNumberExists(string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
