using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TicketingSystem.Infrastructure.Migrations;
using static TicketingSystem.Areas.Client.Constants.ClientConstants;

namespace TicketingSystem.Areas.Client.Controllers
{
    [Area(AreaName)]
    [Route("Client/[controller]/[Action]/{id?}")]
    [Authorize(Roles = ClientRoleName)]
    public class BaseController : Controller
    {
    }
}
