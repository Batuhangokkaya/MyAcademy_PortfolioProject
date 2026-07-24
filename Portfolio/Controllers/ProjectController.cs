using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;
using Portfolio.Data.Entities;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        private readonly AppDbContext _context;

        public ProjectController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var projects = _context.Projects
                .Include(x => x.ProjectTechStacks)
                .ThenInclude(x => x.TechStack)
                .ToList();
            ViewBag.ProjectCount = _context.Projects.Count();
            return View(projects);
        }

        [HttpGet]
        public IActionResult CreateProject()
        {
            var model = new ProjectUpdateViewModel
            {
                SelectedTechStackIds = new List<int>(),

                TechStacks = _context.TechStacks
            .OrderBy(x => x.Name)
            .Select(x => new SelectListItem
            {
                Value = x.ID.ToString(),
                Text = x.Name
            })
            .ToList()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult CreateProject(ProjectUpdateViewModel model)
        {
            model.SelectedTechStackIds ??= new List<int>();

            if (!ModelState.IsValid)
            {
                model.TechStacks = _context.TechStacks
                    .OrderBy(x => x.Name)
                    .Select(x => new SelectListItem
                    {
                        Value = x.ID.ToString(),
                        Text = x.Name
                    })
                    .ToList();

                return View(model);
            }

            var project = new Project
            {
                Name = model.Name,
                ImageURL = model.ImageURL,
                Description = model.Description,
                GithubURL = model.GithubURL
            };

            _context.Projects.Add(project);
            _context.SaveChanges();

            foreach (var techStackId in model.SelectedTechStackIds.Distinct())
            {
                _context.ProjectTechStacks.Add(new ProjectTechStack
                {
                    ProjectID = project.ID,
                    TechStackID = techStackId
                });
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Project");
        }

        [HttpGet]
        public IActionResult UpdateProject(int id)
        {
            var project = _context.Projects
                .Include(x => x.ProjectTechStacks)
                .FirstOrDefault(x => x.ID == id);

            if (project == null)
            {
                return NotFound();
            }

            var model = new ProjectUpdateViewModel
            {
                ID = project.ID,
                Name = project.Name,
                ImageURL = project.ImageURL,
                Description = project.Description,
                GithubURL = project.GithubURL,
                SelectedTechStackIds = project.ProjectTechStacks
                    .Select(x => x.TechStackID)
                    .ToList(),

                TechStacks = _context.TechStacks
                    .OrderBy(x => x.Name)
                    .Select(x => new SelectListItem
                    {
                        Value = x.ID.ToString(),
                        Text = x.Name
                    })
                    .ToList()
            };

            return View(model);
        }

        [HttpPost]

        public IActionResult UpdateProject(ProjectUpdateViewModel project)
        {
            project.SelectedTechStackIds ??= new List<int>();
            if (!ModelState.IsValid)
            {
                project.TechStacks = _context.TechStacks
                    .OrderBy(x => x.Name)
                    .Select(x => new SelectListItem
                    {
                        Value = x.ID.ToString(),
                        Text = x.Name
                    })
                    .ToList();
                return View(project);
            }

            var existingProject = _context.Projects
                .Include(x => x.ProjectTechStacks)
                .FirstOrDefault(x => x.ID == project.ID);
            
            if (existingProject == null)
            {
                return NotFound();
            }
            
            existingProject.Name = project.Name;
            existingProject.ImageURL = project.ImageURL;
            existingProject.Description = project.Description;
            existingProject.GithubURL = project.GithubURL;
            _context.ProjectTechStacks.RemoveRange(

                existingProject.ProjectTechStacks

            );

            var selectedIds = project.SelectedTechStackIds
                .Distinct()
                .ToList();

            foreach (var techStackId in selectedIds)
            {
                existingProject.ProjectTechStacks.Add(new ProjectTechStack
                {
                    ProjectID = existingProject.ID,
                    TechStackID = techStackId
                });
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Project");
        }

        public IActionResult DeleteProject(int id)
        {
            var project = _context.Projects.Find(id);
            _context.Projects.Remove(project);
            _context.SaveChanges();
            return RedirectToAction("Index", "Project");
        }
    }
}