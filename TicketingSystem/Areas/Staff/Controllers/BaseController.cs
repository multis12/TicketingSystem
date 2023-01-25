using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static TicketingSystem.Areas.Staff.Constants.StaffConstants;

namespace TicketingSystem.Areas.Staff.Controllers
{
    [Area(AreaName)]
    [Route("Staff/[controller]/[Action]/{id?}")]
    [Authorize(Roles = StaffRoleName)]
    public class BaseController : Controller
    {
    }
}
