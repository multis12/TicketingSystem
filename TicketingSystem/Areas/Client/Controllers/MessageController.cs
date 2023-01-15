using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using TicketingSystem.Core.Contracts;

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
        public async ITask<IActionResult> Create(int id)
        {
            
        }
    }
}
