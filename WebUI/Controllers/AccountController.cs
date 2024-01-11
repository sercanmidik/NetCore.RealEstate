using DtoLayer.AccountDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
       
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Login(LoginUserDto loginUser)
        {
            if (ModelState.IsValid)
            {
                var result=await _signInManager.PasswordSignInAsync(loginUser.UserName,loginUser.Password,false,false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "AdminBrand");
                }
            }
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Default");
        }

    }
}
