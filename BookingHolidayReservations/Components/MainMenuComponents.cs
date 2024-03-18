using Microsoft.AspNetCore.Mvc;

namespace BookingHolidayReservations.Components
{
    public class MainMenuComponents : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult<IViewComponentResult>(View());
        }
    }
}
