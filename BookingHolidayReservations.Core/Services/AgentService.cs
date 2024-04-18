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

        public async Task CreateAsync(string userId, string phoneNumber)
        {
            await repository.AddAsync(new Administrator()
            {
                Username = userId,
                PhoneNumber = phoneNumber,
            });
            await repository.SaveChangesAsync();    
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

        public async Task<bool> UserHasRentsAsync(string userId)
        {
           return await repository.AllReadOnly<HolidayDestination>()
                .AnyAsync(h => h.Id.ToString() == userId);
        }

        public async Task<bool> UserWithPhoneNumberExists(string phoneNumber)
        {
            return await repository.AllReadOnly<Administrator>()
                .AllAsync(a => a.PhoneNumber == phoneNumber);
        }
    }
}
