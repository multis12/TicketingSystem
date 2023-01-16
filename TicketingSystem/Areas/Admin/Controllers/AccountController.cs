using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Account;
using TicketingSystem.Core.Models.Project;
using TicketingSystem.Core.Models.Tickets;
using TicketingSystem.Core.Services;
using static TicketingSystem.Areas.Admin.Constants.AdminConstants;

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
        public async Task<IActionResult> AllRequests()
        {
            if (!User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            var model = await accountService.AllRequests();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AllRequests(IEnumerable<AccountModel> model)
        {
            return RedirectToAction("AllRequests", "Account", new { area = "Admin" });
        }

        [HttpGet]
        public async Task<IActionResult> Approve(string id)
        {
            if (!User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            var user = await accountService.DetailsById(id);

            var accountRoleId = await accountService.GetAccountRoleId(id);

            var model = new AccountModel()
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
        public async Task<IActionResult> Approve(AccountModel model)
        {
            if (!ModelState.IsValid)
            {
                model.AccountRequestRoles = await accountService.GetAllAccountRoles();

                return View(model);
            }

            await accountService.Approve(model, model.Id);

            return RedirectToAction("AllRequests", "Account", new { area = "Admin" });
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            if (!User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            var model = await accountService.All();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> All(IEnumerable<AccountModel> model)
        {
            return RedirectToAction("All", "Account", new { area = "Admin" });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            if (!User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            var acc = await accountService.DetailsById(id);

            var model = new AccountDeleteModel()
            {
                Email = acc.Email,
                FirstName = acc.FirstName,
                SecondName = acc.SecondName,
                UserName = acc.UserName
            };

            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id, AccountDeleteModel model)
        {
            if (!User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            await accountService.Delete(id);

            return RedirectToAction("All", "Account", new { area = "Admin" });
        }

        //[HttpGet]
        //public async Task<IActionResult> Edit(string id)
        //{
        //    var acc = await accountService.DetailsById(id);
            
        //    acc.AccountRequestRoleId = await accountService.GetAccountRoleId(id);

        //    var model = new AccountEditModel()
        //    {
        //        a
        //    }
        //}
    }
}
