using Microsoft.AspNetCore.Mvc;

namespace TicketingSystem.Areas.Staff.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
