using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;

namespace Portfolio.Controllers
{
    public class SkillController : Controller
    {
        private readonly AppDbContext _context;

        public SkillController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Skill skill)
        {
            skill.IsActive = true;
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("Index", "Skill");
        }

        public IActionResult Delete(int id)
        {
            var value = _context.Skills.Find(id);
            _context.Skills.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Index", "Skill");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value = _context.Skills.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Skill skill)
        {
            skill.IsActive = true;
            _context.Skills.Update(skill);
            _context.SaveChanges();
            return RedirectToAction("Index", "Skill");
        }
    }
}