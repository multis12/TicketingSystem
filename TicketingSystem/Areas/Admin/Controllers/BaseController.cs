using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using static TicketingSystem.Areas.Admin.Constants.AdminConstants;

namespace TicketingSystem.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Route("Admin/[controller]/[Action]/{id?}")]
    [Authorize(Roles = AdminRoleName)]
    public class BaseController : Controller
    {
    }
}
