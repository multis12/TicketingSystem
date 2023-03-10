using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Project;

namespace TicketingSystem.Areas.Client.Controllers
{
    public class ProjectController : BaseController
    {
        private readonly IProjectService projectService;

        public ProjectController(IProjectService _projectService)
        {
            projectService = _projectService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await projectService.All();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> All(IEnumerable<ProjectViewModel> model)
        {
            return RedirectToAction("All", "Project", new { area = "Client" });
        }

        public async Task<IActionResult> Details(int id)
        {
            var userId = User.Claims.FirstOrDefault(a => a.Type == ClaimTypes.NameIdentifier)?.Value;

            var model = await projectService.DetailsById(id, userId);

            return View(model);
        }
    }
}
