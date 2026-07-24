using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ProjectTechStacksController : Controller
    {
        private readonly AppDbContext _context;

        public ProjectTechStacksController(AppDbContext context)
        {
            _context = context;
        }

        // Eager Loading
        public IActionResult Index()
        {
            var values = _context.Projects
                .Select(project => new ProjectTechStackViewModel
                {
                   ProjectName = project.Name,

                   TechStack = project.ProjectTechStacks!
                       .Select(x => new ProjectTechStackItemViewModel
                       {
                           Id = x.ID,
                           Name = x.TechStack.Name
                       })
                       .ToList()
               })
               .ToList();

            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var projects   = _context.Projects.ToList();
            var TechStacks = _context.TechStacks.ToList();

            ViewBag.Projects   = (from project in projects

                                  select new SelectListItem
                                  {
                                      Text  = project.Name,
                                      Value = project.ID.ToString(),
                                  }).ToList();

            ViewBag.TechStacks = (from tech in TechStacks
                                  select new SelectListItem
                                  {
                                      Text  = tech.Name,
                                      Value = tech.ID.ToString(),
                                  });
            return View();
        }
  
        [HttpPost]
        public IActionResult Create(ProjectTechStack projectTechStack)
        {
            _context.ProjectTechStacks.Add(projectTechStack);
            _context.SaveChanges();
            return RedirectToAction("Index", "ProjectTechStacks");
        }


        public IActionResult Delete(int id)
        {
            var value = _context.ProjectTechStacks.Find(id);

            if (value != null)
            {
                _context.ProjectTechStacks.Remove(value);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "ProjectTechStacks");
        }
    }
}