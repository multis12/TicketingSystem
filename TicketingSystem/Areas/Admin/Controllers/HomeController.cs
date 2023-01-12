using Microsoft.AspNetCore.Mvc;

namespace TicketingSystem.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
