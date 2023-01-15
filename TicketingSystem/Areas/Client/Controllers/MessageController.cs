using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using System.Security.Claims;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Messages;

namespace TicketingSystem.Areas.Client.Controllers
{
    public class MessageController : BaseController
    {
        private readonly IMessageService messageService;
        public MessageController(IMessageService _messageService)
        {
            messageService = _messageService;
        }

        [HttpGet]
        public async Task<IActionResult> Create(int id)
        {
            var model = new MessageModel()
            {
                Conditions = await messageService.GetAllMessageTypes()
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Create(MessageModel model, int id)
        {
            var userId = User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier)?.Value;

            if (!ModelState.IsValid)
            {
                model.Conditions = await messageService.GetAllMessageTypes();

                return View(model);
            }

            await messageService.Create(model, model.FilePath, userId, id);

            return RedirectToAction(nameof(TicketController.Details));

        }
    }
}
