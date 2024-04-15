using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookingHolidayReservations.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}
