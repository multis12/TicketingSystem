using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using TicketingSystem.Core.Models.Account;
using TicketingSystem.Infrastructure.Data;

namespace TicketingSystem.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        private readonly SignInManager<AppUser> signInManager;

        public AccountController(
            UserManager<AppUser> _userManager,
            SignInManager<AppUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
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

            var result = await userManager.CreateAsync(user, model.Password);

            await userManager.AddToRoleAsync(user, "Administrator");
            //await userManager.AddToRoleAsync(user, "Administrator");
            //if (await userManager.IsInRoleAsync(user, "Administrator"))
            //{
            //    await userManager.AddToRoleAsync(user, "Client");
            //    await userManager.AddToRoleAsync(user, "Staff");
            //}

            if (result.Succeeded)
            {
               
                return RedirectToAction("Login", "Account", new { area = "" });
            }

            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            var model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByEmailAsync(model.Email);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (result.Succeeded)
                {
                    if (await userManager.IsInRoleAsync(user, "Administrator"))
                    {
                        return RedirectToAction("Index", "Home", new { area = "Admin" });
                    }
                    else if (await userManager.IsInRoleAsync(user,"Staff"))
                    {
                        return RedirectToAction("Index", "Home", new { area = "Staff" });
                    }
                    else if (await userManager.IsInRoleAsync(user,"Client"))
                    {
                        return RedirectToAction("Index", "Home", new { area = "Client" });
                    }
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
            }
            ModelState.AddModelError("", "Invalid login");

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
