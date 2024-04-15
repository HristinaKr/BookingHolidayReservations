using BookingHolidayReservations.Core.Contracts;
using BookingHolidayReservations.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookingHolidayReservations.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
		private readonly IHolidaysService holidaysService;

		public HomeController(
			ILogger<HomeController> logger,
			IHolidaysService _holidaysService)
		{
			_logger = logger;
			holidaysService = _holidaysService;
		}

        [AllowAnonymous]
		public async Task<IActionResult> Index()
        {

            var model = await holidaysService.AllTrips();
            return View(model);
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}