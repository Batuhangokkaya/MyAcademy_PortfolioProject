using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class EducationController : Controller
    {
        private readonly AppDbContext _context;

        public EducationController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Educations.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Education education)
        {
            _context.Educations.Add(education);
            _context.SaveChanges();
            return RedirectToAction("Index", "Education");
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Educations.Find(id);
            _context.Educations.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index", "Education");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.Educations.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Education education)
        {
            _context.Educations.Update(education);
            _context.SaveChanges();
            return RedirectToAction("Index", "Education");
        }
    }
}