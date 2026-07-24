using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
            return RedirectToAction("Index", "Service");
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Services.Find(id);
            _context.Services.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index", "Service");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.Services.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Service service)
        {
            _context.Services.Update(service);
            _context.SaveChanges();
            return RedirectToAction("Index", "Service");
        }
    }
}