using Microsoft.AspNetCore.Mvc;

namespace BookingHolidayReservations.Controllers
{
    public class Component : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View());
        }
    }
}
