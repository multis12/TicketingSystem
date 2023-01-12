using Microsoft.AspNetCore.Mvc;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Project;

namespace TicketingSystem.Areas.Admin.Controllers
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
            var model = projectService.All();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> All(IEnumerable<ProjectModel> model)
        {
            return RedirectToAction("All", "Project", new { area = "Admin" });
        }
    }
}
