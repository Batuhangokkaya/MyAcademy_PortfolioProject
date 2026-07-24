using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class Dashboard : Controller
    {
        private readonly AppDbContext _context;

        public Dashboard(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = new DashboardViewModel
            {
                Projects = _context.Projects
                .Include(x => x.ProjectTechStacks)
                .ThenInclude(x => x.TechStack)
                .OrderByDescending(x => x.ID)
                .ToList(),

                userMessages = _context.UserMessages
                .Take(4)
                .ToList(),

                Skills = _context.Skills
                .Take(6)
                .ToList()
            };

            ViewBag.ProjectCount = _context.Projects.Count();
            ViewBag.SkillCount   = _context.Skills.Count();
            ViewBag.Message      = _context.UserMessages.Count();
            ViewBag.ServiceCount = _context.Services.Count();

            return View(values);
        }
    }
}