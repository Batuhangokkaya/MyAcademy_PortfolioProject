using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class TechStackController : Controller
    {
        private readonly AppDbContext _context;

        public TechStackController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var value = _context.TechStacks
                .Include(x => x.Category)
                .ToList();

            ViewBag.TechStacksCount = _context.TechStacks.Count();
            return View(value);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var categoryList = _context.TechStacks
                .Select(x => new SelectListItem
                {
                    Text  = x.Category.Name,
                    Value = x.Category.ID.ToString()
                })
                .Distinct()
                .ToList();

            ViewBag.CategoryList = categoryList;

            return View();
        }

        [HttpPost]
        public IActionResult Create(TechStack techStack)
        {
            _context.TechStacks.Add(techStack);
            _context.SaveChanges();
            return RedirectToAction("Index", "TechStack");
        }

        public IActionResult Delete(int id)
        {
            var value = _context.TechStacks.Find(id);
            _context.TechStacks.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index", "TechStack");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.TechStacks.Find(id);

            var categoryList = _context.TechStacks
                .Select(x => new SelectListItem
                {
                    Text = x.Category.Name,
                    Value = x.Category.ID.ToString()
                })
                .Distinct()
                .ToList();

            ViewBag.CategoryList = categoryList;

            return View(value);
        }

        [HttpPost]
        public IActionResult Update(TechStack techStack)
        {
            _context.TechStacks.Update(techStack);
            _context.SaveChanges();
            return RedirectToAction("Index", "TechStack");
        }
    }
}