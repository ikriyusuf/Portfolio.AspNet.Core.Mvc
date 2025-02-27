using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        // Constructor to inject services
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([FromForm] LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await _userManager.FindByNameAsync(loginModel.Name);
                if (user is not null)
                {
                    await _signInManager.SignOutAsync();
                    if ((await _signInManager.PasswordSignInAsync(user, loginModel.Password, false, false)).Succeeded)
                    {
                        return RedirectToAction("Index", "Dashboard");
                    }
                }
                ModelState.AddModelError("Error", "Invalid username or password.");
            }
            return View();
        }

        // POST: Account/Logout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            // Kullanıcıyı çıkış yapar
            await _signInManager.SignOutAsync();

            // Çıkış yaptıktan sonra kullanıcıyı anasayfaya yönlendir
            return RedirectToAction("Index", "Home");
        }
    }
}
