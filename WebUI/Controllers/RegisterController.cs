using DtoLayer.AccountDtos;
using EntityLayer.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AccountCreate(CreateAccountDto createAccountDto)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    Name = createAccountDto.Name,
                    Email = createAccountDto.Email,
                    SurName = createAccountDto.SurName,
                    UserName = createAccountDto.UserName,
                };
                var result = await _userManager.CreateAsync(appUser, createAccountDto.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }
            }

            return View();
        }
    }
}
