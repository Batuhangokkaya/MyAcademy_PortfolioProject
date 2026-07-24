using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class BannerController : Controller
    {
        private readonly AppDbContext _context;

        public BannerController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var about = _context.Banners.FirstOrDefault();
            return View(about);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Banner banner)
        {
            _context.Banners.Add(banner);
            _context.SaveChanges();
            return RedirectToAction("Index", "Banner");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.Banners.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Banner banner)
        {
            _context.Banners.Update(banner);
            _context.SaveChanges();
            return RedirectToAction("Index", "Banner");
        }

        public IActionResult Delete(int id)
        {
            var about = _context.Banners.Find(id);
            _context.Banners.Remove(about);
            _context.SaveChanges();
            return RedirectToAction("Index", "Banner");
        }
    }
}