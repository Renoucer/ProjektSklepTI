using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjektSklepTI.Models.Users;

namespace ProjektSklepTI.Controllers
{
    public class AccountController : Controller
    {
        UserManager<AppUser> _userManager;

        SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IActionResult> Login()
        {
            var result = await _signInManager.PasswordSignInAsync("TestUser", "Test", false, false);
            ViewBag.result = "Zarejestrowano użytkownika\n" + result;


            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.result = $"Nie udało się ({result})";
            }

            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);

                if (user == null)
                {
                    user = new AppUser()
                    {
                        UserName = model.UserName,
                        Email = model.Email,
                        FirstName = model.FirstName,
                        LastName = model.LastName
                    };

                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        ViewBag.result = "Zarejestrowano";
                        await _signInManager.SignInAsync(user, false);

                        return RedirectToAction("Index", "Home");
                    }
                    else { ViewBag.result = "Rejestracja nieudana."; }



                    return View();
                }
                else
                {
                    return View(model);
                }
            }
            else
            {
                ViewBag.result = "uzytkonwik o tej nazwie isntieje";
                return View(model);  
            }
        }
        

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}