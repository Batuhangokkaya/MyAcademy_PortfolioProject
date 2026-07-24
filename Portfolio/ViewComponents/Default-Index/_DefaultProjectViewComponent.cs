using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultProjectViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultProjectViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Projects
                .Include(x => x.ProjectTechStacks)
                .ThenInclude(x => x.TechStack)
                .ToList();
            return View(values);
        }
    }
}