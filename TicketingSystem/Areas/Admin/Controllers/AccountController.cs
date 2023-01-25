using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TicketingSystem.Core.Contracts;
using TicketingSystem.Core.Models.Account;
using TicketingSystem.Infrastructure.Data;
using static TicketingSystem.Areas.Admin.Constants.AdminConstants;

namespace TicketingSystem.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IAccountService accountService;
        private readonly UserManager<AppUser> userManager;

        public AccountController(IAccountService _accountService, UserManager<AppUser> _userManager)
        {
            accountService = _accountService;
            userManager = _userManager;
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

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if (!User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            var acc = await accountService.DetailsById(id);

            var accountRequestRoleId = await accountService.GetAccountRoleId(id);

            var model = new AccountEditModel()
            {
                Id = acc.Id,
                FirstName = acc.FirstName,
                SecondName = acc.SecondName,
                UserName = acc.UserName,
                Email = acc.Email,
                AccountRequestRoleId = accountRequestRoleId,
                AccountRequestRoles = await accountService.GetAllAccountRoles()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AccountEditModel model)
        {
            if (!ModelState.IsValid)
            {
                model.AccountRequestRoles = await accountService.GetAllAccountRoles();

                return View(model);
            }

            await accountService.Edit(model, model.Id);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (!User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            var model = new RegisterViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = new AppUser()
            {
                FirstName = model.FirstName,
                SecondName = model.SecondName,
                Email = model.Email,
                UserName = model.UserName
            };
            user.AccountRoleId = 2;

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "Client");

                return RedirectToAction(nameof(AllRequests));
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }
    }
}
