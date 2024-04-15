using BookingHolidayReservations.Core.Contracts;
using BookingHolidayReservations.Core.Models.Agent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookingHolidayReservations.Controllers
{

	public class AgentController : BaseController
	{
		private readonly IAgentService agentService;

        public AgentController(IAgentService _agentService)
        {
			agentService = _agentService;	
        }

        [HttpGet]
		
		public async Task<IActionResult> BecomeAgent()
		{
			var model = new BecomeAgentModel();
			return View(model);
		}

		[HttpPost]

		public async Task<IActionResult> Become(BecomeAgentModel model)
		{
			return RedirectToAction(nameof(HolidaysController.All), "Holiday");
		}
	}
}
