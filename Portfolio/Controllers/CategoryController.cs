using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var frontendCategoryId = _context.Categories
                .Where(x => x.Name == "Frontend")
                .Select(x => x.ID)
                .FirstOrDefault();

            ViewBag.FrontendProjectCount = _context.ProjectTechStacks
                .Where(x => x.TechStack.CategoryID == frontendCategoryId)
                .Select(x => x.ProjectID)
                .Distinct()
                .Count();

            var backendCategoryId = _context.Categories
                .Where(x => x.Name == "Backend")
                .Select(x => x.ID)
                .FirstOrDefault();

            ViewBag.BackendProjectCount = _context.ProjectTechStacks
                .Where(x => x.TechStack.CategoryID == backendCategoryId)
                .Select(x => x.ProjectID)
                .Distinct()
                .Count();

            ViewBag.CategoryCount    = _context.Categories.Count();

            var values = _context.Categories.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index", "Category");
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Categories.Find(id);
            _context.Categories.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index", "Category");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.Categories.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
            return RedirectToAction("Index", "Category");
        }
    }
}