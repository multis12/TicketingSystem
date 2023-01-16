using Microsoft.AspNetCore.Mvc;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Account;
using TicketingSystem.Core.Models.Project;
using TicketingSystem.Core.Models.Tickets;
using TicketingSystem.Core.Services;

namespace TicketingSystem.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IAccountService accountService;

        public AccountController(IAccountService _accountService)
        {
            accountService = _accountService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await accountService.All();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> All(IEnumerable<AccountRequestModel> model)
        {
            return RedirectToAction("All", "Account", new { area = "Admin" });
        }

        [HttpGet]
        public async Task<IActionResult> Approve(string id)
        {
            var user = await accountService.DetailsById(id);

            var accountRoleId = await accountService.GetAccountRoleId(id);

            var model = new AccountRequestModel()
            {
                Id = id,
                AccountRequestRoleId = accountRoleId,
                AccountRequestRoles = await accountService.GetAllAccountRoles(),
                Email = user.Email,
                FirstName = user.FirstName,
                SecondName = user.SecondName,
                UserName = user.UserName
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Approve(AccountRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                model.AccountRequestRoles = await accountService.GetAllAccountRoles();

                return View(model);
            }

            await accountService.Approve(model, model.Id);

            return RedirectToAction("All", "Account", new { area = "Admin" });
        }
    }
}
