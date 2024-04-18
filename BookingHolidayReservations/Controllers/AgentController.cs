using BookingHolidayReservations.Core.Contracts;
using BookingHolidayReservations.Core.Models.Agent;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
			if(await agentService.ExistsById(User.Id()))
			{
				return BadRequest(); 
			}
			var model = new BecomeAgentModel();
			return View(model);
		}

		[HttpPost]

		public async Task<IActionResult> BecomeAgent(BecomeAgentModel model)
		{
			return RedirectToAction(nameof(HolidaysController.All), "Holiday");
		}
	}
}
