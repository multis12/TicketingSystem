using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Tickets;

namespace TicketingSystem.Areas.Client.Controllers
{
    public class TicketController : BaseController
    {
        private readonly ITicketService ticketService;

        public TicketController(ITicketService _ticketService)
        {
            ticketService = _ticketService;
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var userId = User.Claims.FirstOrDefault(a => a.Type == ClaimTypes.NameIdentifier)?.Value;

            var model = new TicketModel()
            {
                Conditions = await ticketService.AllTicketConditions(),
                Types = await ticketService.AllTicketTypes(),
                UserId = userId
            };
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TicketModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Conditions = await ticketService.AllTicketConditions();
                model.Types = await ticketService.AllTicketTypes();

                return View(model);
            }

            await ticketService.Create(model, model.FilePath);

            return RedirectToAction(nameof(ProjectController.All));
        }
    }
}
