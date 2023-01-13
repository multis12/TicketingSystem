using Microsoft.AspNetCore.Mvc;

namespace TicketingSystem.Areas.Client.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
