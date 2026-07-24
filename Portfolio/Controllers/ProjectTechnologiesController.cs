using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.Controllers
{
    public class ProjectTechnologiesController : Controller
    {
        private readonly AppDbContext _context;

        public ProjectTechnologiesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.ProjectTechStacks.ToList();
            return View(values);
        }
    }
}