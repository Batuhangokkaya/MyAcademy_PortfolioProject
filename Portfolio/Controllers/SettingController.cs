using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;

        public SettingController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value = _context.Admins.FirstOrDefault();
            return View(value);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Admin admin)
        {
            _context.Admins.Add(admin);
            _context.SaveChanges();
            return RedirectToAction("Index", "Setting");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.Admins.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Admin admin)
        {
            _context.Admins.Update(admin);
            _context.SaveChanges();
            return RedirectToAction("Index", "Setting");
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Admins.Find(id);
            _context.Admins.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index", "Setting");
        }
    }
}