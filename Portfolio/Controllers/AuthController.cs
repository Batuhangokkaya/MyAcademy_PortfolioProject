using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Models;
using System.Security.Claims;

namespace Portfolio.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            var admin = _context.Admins.FirstOrDefault(x => x.UserName == loginVM.UserName && x.Password == loginVM.Password);

            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }

            if (admin == null)
            {
                ModelState.AddModelError(string.Empty, "Kullanıcı Adı veya Şifre Hatalı!");
                return View(admin);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, admin.UserName),
                new Claim("FullName", admin.FullName),
                new Claim("Image", admin.ImageURL),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProps = new AuthenticationProperties
            {
                ExpiresUtc   = DateTime.UtcNow.AddMinutes(30),
                IsPersistent = false
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProps);

            HttpContext.Session.SetString("FullName", admin.FullName);
            HttpContext.Session.SetString("Image", admin.ImageURL);

            return RedirectToAction("Index", "Dashboard");
        }

        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Remove("FullName");
            HttpContext.Session.Remove("Image");
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login", "Auth");
        }
    }
}