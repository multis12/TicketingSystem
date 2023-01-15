using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TicketingSystem.Areas.Client.Controllers;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Tickets;

namespace TicketingSystem.Areas.Staff.Controllers
{
    public class TicketController : BaseController
    {
        private readonly ITicketService ticketService;
        public TicketController(ITicketService _ticketService)
        {
            ticketService = _ticketService;
        }

        public async Task<IActionResult> Delete(int id)
        {
            await ticketService.Delete(id);
            
            return RedirectToAction("All", "Project", new { area = "Client"});
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var ticket = await ticketService.DetailsById(id);

            var conditionId = await ticketService.GetTicketConditionId(id);

            var typeId = await ticketService.GetTicketTypeId(id);

            var model = new TicketEditModel()
            {
                Id = id,
                DateAndTime = ticket.DateAndTime,
                ConditionId = conditionId,
                TypeId = typeId,
                Conditions = await ticketService.AllTicketConditions(),
                Description = ticket.Description,
                Email = ticket.Email,
                FilePath = ticket.FilePath,
                FirstName = ticket.FirstName,
                Messages = ticket.Messages,
                SecondName = ticket.SecondName,
                Title = ticket.Title,
                Types = await ticketService.AllTicketTypes()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(TicketEditModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Conditions = await ticketService.AllTicketConditions();
                model.Types = await ticketService.AllTicketTypes();

                return View(model);
            }

            await ticketService.Edit(model, model.Id);

            return RedirectToAction("All", "Project", new { area = "Client"});
        }
    }
}
