using Microsoft.AspNetCore.Mvc;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Project;
using static TicketingSystem.Areas.Admin.Constants.AdminConstants;

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
        public async Task<IActionResult> Add()
        {
            if (!User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            var model = new ProjectModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProjectModel model)
        {
            if (!User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await projectService.Create(model);

            return RedirectToAction(nameof(Client.Controllers.ProjectController.All), new { area = "Client" });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (!User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            var project = await projectService.DetailsById(id);

            var model = new ProjectDeleteModel()
            {
                Name = project.Name
            };

            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, ProjectDeleteModel model)
        {
            if (!User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            await projectService.Delete(id);

            return RedirectToAction(nameof(Client.Controllers.ProjectController.All), new { area = "Client" });
        }
    }
}
